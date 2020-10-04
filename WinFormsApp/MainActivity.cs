using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp {
    enum Tool {
        Cursor,
        Drag,
        Pen,
        Rectangle,
        Line,
        Eraser
    }

    enum Transformation {
        Rotate,
        Scale,
        TranslationX,
        TranslationY,
        ReflectionX,
        ReflectionY
    }

    enum Status {
        PenDrawing,
        LineDrawing,
        Dragging,
        ErasePending,
        None
    }

    public partial class mainActivity : Form {
        private readonly Cursor penCursor;
        private readonly Cursor dragCursor;
        private readonly Cursor eraserCursor;

        private Tool currentTool = Tool.Cursor;
        private Status status = Status.None;

        private Point globalTranslation;
        private Point previousMousePos;
        private Point eraserMousePos;

        private readonly List<List<Point>> pathStrokes;
        private List<Point> currentPath;

        public mainActivity() {
            InitializeComponent();
            penCursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "Cursors\\PenCursor.cur");
            dragCursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "Cursors\\DragCursor.cur");
            eraserCursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "Cursors\\EraserCursor.cur");

            currentTool = Tool.Cursor;
            status = Status.None;

            globalTranslation = new Point(drawingBox.Size.Width / 2, drawingBox.Size.Height / 2);
            eraserMousePos = new Point();

            pathStrokes = new List<List<Point>>();
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e) {
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;

            List<List<Point>> strokesToRemove = new List<List<Point>>();
            bool transformationsEnabled = getCheckedStatus();
            decimal rotationAngle = getValue(Transformation.Rotate);
            decimal homothesis = getValue(Transformation.Scale);
            decimal translateX = getValue(Transformation.TranslationX);
            decimal translateY = getValue(Transformation.TranslationY);

            GraphicsPath xAxis = new GraphicsPath();
            GraphicsPath yAxis = new GraphicsPath();
            GraphicsPath path = new GraphicsPath();

            xAxis.AddLine(new Point(-10000, 0), new Point(10000, 0));
            yAxis.AddLine(new Point(0, -10000), new Point(0, 10000));

            foreach (List<Point> stroke in pathStrokes.Where(x => x.Count > 0)) {
                bool shouldDelete = false;
                GraphicsPath p = new GraphicsPath();
                if (stroke.Count == 1)
                    p.AddRectangle(new Rectangle(stroke[0].X, stroke[0].Y, 1, 1));
                else
                    p.AddLines(stroke.ToArray());

                if (eraserMousePos != null && status == Status.ErasePending) {
                    shouldDelete = p.IsOutlineVisible(eraserMousePos, new Pen(Color.Blue, 2));
                    eraserMousePos = new Point();
                }

                if (status == Status.ErasePending)
                    status = Status.None;

                if (!shouldDelete) {
                    path.AddPath(p, false);
                } else {
                    strokesToRemove.Add(stroke);
                }
            }

            Matrix tf = new Matrix();

            if (pathStrokes != null && pathStrokes.Count > 0 && transformationsEnabled) {
                if (getCheckedStatus(Transformation.ReflectionX))
                    tf.Multiply(new Matrix(1, 0, 0, -1, 0, 0), MatrixOrder.Append);

                if (getCheckedStatus(Transformation.ReflectionY))
                    tf.Multiply(new Matrix(-1, 0, 0, 1, 0, 0), MatrixOrder.Append);

                if (getCheckedStatus(Transformation.Rotate))
                    tf.Rotate(-(float)rotationAngle, MatrixOrder.Append);

                if (getCheckedStatus(Transformation.Scale))
                    tf.Scale((float)homothesis, (float)homothesis, MatrixOrder.Append);

                if (getCheckedStatus(Transformation.TranslationX) || getCheckedStatus(Transformation.TranslationY))
                    tf.Translate((float)translateX, -(float)translateY, MatrixOrder.Append);
            }

            updateMatrixValues(tf);

            world.TranslateTransform(globalTranslation.X, globalTranslation.Y);
            world.DrawPath(new Pen(Color.Black, 1), xAxis);
            world.DrawPath(new Pen(Color.Black, 1), yAxis);

            if (pathStrokes != null && pathStrokes.Count > 0) {
                if (multipleViewCheckbox.Checked)
                    world.DrawPath(new Pen(Color.Green, 2), path);

                if (getValue(Transformation.Scale) != 0) {
                    if (transformationsEnabled)
                        path.Transform(tf);
                    world.DrawPath(new Pen(Color.Blue, 2), path);
                }
            }

            foreach (List<Point> stroke in strokesToRemove) {
                _ = pathStrokes.Remove(stroke);
            }
        }

        private void drawingBox_MouseDown(object sender, MouseEventArgs e) {
            if (currentTool == Tool.Line) {
                if (status == Status.None) {
                    status = Status.LineDrawing;
                    currentPath = new List<Point>();
                    pathStrokes.Add(currentPath);
                }

                Point mousePos = calculatePointWithOffset(e.Location);
                currentPath.Add(mousePos);
                Refresh();
            } else if (currentTool == Tool.Pen) {
                if (status == Status.None) {
                    status = Status.PenDrawing;
                    currentPath = new List<Point>();
                    pathStrokes.Add(currentPath);

                    Point mousePos = calculatePointWithOffset(e.Location);
                    if (currentPath != null)
                        currentPath.Add(mousePos);
                    Refresh();
                }
            } else if (currentTool == Tool.Drag) {
                if (status == Status.None) {
                    status = Status.Dragging;
                    previousMousePos = e.Location;
                }
            } else if (currentTool == Tool.Eraser) {
                if (status == Status.None) {
                    status = Status.ErasePending;
                    eraserMousePos = calculatePointWithOffset(e.Location);
                    Refresh();
                }
            }
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e) {
            // Prevent the event to fire twice for the same mouse location
            // See https://stackoverflow.com/a/23048201
            Point mousePos = e.Location;
            if (mousePos == previousMousePos)
                return;

            if (currentTool == Tool.Pen && status == Status.PenDrawing) {
                mousePos = calculatePointWithOffset(e.Location);
                if (currentPath != null)
                    currentPath.Add(mousePos);
                Refresh();
            } else if (currentTool == Tool.Drag && status == Status.Dragging) {
                int deltaX = mousePos.X - previousMousePos.X;
                int deltaY = mousePos.Y - previousMousePos.Y;

                globalTranslation.X += deltaX;
                globalTranslation.Y += deltaY;
                previousMousePos = mousePos;
                Refresh();
            }
        }

        private void drawingBox_MouseUp(object sender, MouseEventArgs e) {
            if (currentTool == Tool.Pen && status == Status.PenDrawing) {
                status = Status.None;
                currentPath = null;
            } else if (currentTool == Tool.Drag && status == Status.Dragging) {
                status = Status.None;
            }
        }

        private Point calculatePointWithOffset(Point originalMouseLoc) {
            Point realMouseLoc = new Point(originalMouseLoc.X, originalMouseLoc.Y);
            realMouseLoc.X -= globalTranslation.X;
            realMouseLoc.Y -= globalTranslation.Y;
            return realMouseLoc;
        }

        private void mainActivity_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                // Prevent the key from bubbling up and remove the ANNOYING ding sound
                // See https://stackoverflow.com/a/16350929
                e.Handled = true;
                e.SuppressKeyPress = true;

                getToolBtn(Tool.Cursor).PerformClick();
            }
        }

        private void updateMatrixValues(Matrix matrix) {
            List<string> values = new List<string>();
            foreach (float value in matrix.Elements.ToArray()) {
                values.Add(value.ToString());
            }
            matrixLayout.GetControlFromPosition(0, 0).Text = values[0];
            matrixLayout.GetControlFromPosition(1, 0).Text = values[1];
            matrixLayout.GetControlFromPosition(0, 1).Text = values[2];
            matrixLayout.GetControlFromPosition(1, 1).Text = values[3];
            matrixLayout.GetControlFromPosition(0, 2).Text = values[4];
            matrixLayout.GetControlFromPosition(1, 2).Text = values[5];
        }

        private void refreshScreen_Event(object sender, EventArgs e) =>
            Refresh();

        private void numeric_ValueChanged(object sender, EventArgs e) {
            bool checkedStatus = false;
            NumericUpDown numericUpDown = sender as NumericUpDown;

            if (numericUpDown == (getTransformation(Transformation.Rotate, typeof(NumericUpDown)) as NumericUpDown)) {
                if (numericUpDown.Value > (decimal)359.9 || numericUpDown.Value < (decimal)-359.9)
                    numericUpDown.Value = 0;

                checkedStatus = getCheckedStatus(Transformation.Rotate);
            } else if (numericUpDown == (getTransformation(Transformation.Scale, typeof(NumericUpDown)) as NumericUpDown)) {
                checkedStatus = getCheckedStatus(Transformation.Scale);
            } else if (numericUpDown == (getTransformation(Transformation.TranslationX, typeof(NumericUpDown)) as NumericUpDown)) {
                checkedStatus = getCheckedStatus(Transformation.TranslationX);
            } else if (numericUpDown == (getTransformation(Transformation.TranslationY, typeof(NumericUpDown)) as NumericUpDown)) {
                checkedStatus = getCheckedStatus(Transformation.TranslationY);
            }

            if (checkedStatus)
                Refresh();
        }

        private void applyTransformations_CheckedChanged(object sender, EventArgs e) =>
            Refresh();

        private void cleanTransformBtn_Click(object sender, EventArgs e) {
            foreach (Transformation tf in Enum.GetValues(typeof(Transformation))) {
                (getTransformation(tf, typeof(CheckBox)) as CheckBox).Checked = false;
            }

            (getTransformation(Transformation.Rotate, typeof(NumericUpDown)) as NumericUpDown).Value = 0;
            (getTransformation(Transformation.Scale, typeof(NumericUpDown)) as NumericUpDown).Value = 1;
            (getTransformation(Transformation.TranslationX, typeof(NumericUpDown)) as NumericUpDown).Value = 0;
            (getTransformation(Transformation.TranslationY, typeof(NumericUpDown)) as NumericUpDown).Value = 0;
        }

        private void selectTool_Click(object sender, EventArgs e) {
            ToolStripButton btn = sender as ToolStripButton;
            Tool senderTool = getToolFromBtn(btn);

            if (!btn.Checked) {
                foreach (Tool tool in Enum.GetValues(typeof(Tool))) {
                    if (tool != senderTool) {
                        getToolBtn(tool).Checked = false;
                        getToolBtn(tool).CheckState = CheckState.Unchecked;
                    }
                }

                drawingBox.Cursor = getToolCursor(senderTool);
                currentTool = senderTool;
                status = Status.None;
                if (currentPath != null)
                    currentPath = null;

                btn.Checked = true;
                btn.CheckState = CheckState.Checked;
            } else {
                if (currentTool != Tool.Cursor && currentTool == senderTool)
                    selectTool_Click(getToolBtn(Tool.Cursor), e);
            }
        }

        private ToolStripButton getToolBtn(Tool tool) {
            switch (tool) {
                case Tool.Drag:
                    return dragToolBtn;
                case Tool.Pen:
                    return penToolBtn;
                case Tool.Line:
                    return lineToolBtn;
                case Tool.Eraser:
                    return eraserToolBtn;
                case Tool.Cursor:
                default:
                    return cursorToolBtn;
            }
        }

        private Tool getToolFromBtn(ToolStripButton btn) {
            foreach (Tool tool in Enum.GetValues(typeof(Tool))) {
                if (btn == getToolBtn(tool))
                    return tool;
            }
            return Tool.Cursor;
        }

        private Cursor getToolCursor(Tool tool) {
            switch (tool) {
                case Tool.Drag:
                    return dragCursor;
                case Tool.Pen:
                    return penCursor;
                case Tool.Line:
                    return Cursors.Cross;
                case Tool.Eraser:
                    return eraserCursor;
                case Tool.Cursor:
                default:
                    return Cursors.Default;
            }
        }

        private dynamic getTransformation(Transformation tf, Type type) {
            if (type == typeof(NumericUpDown)) {
                switch (tf) {
                    case Transformation.Rotate:
                        return rotationValue;
                    case Transformation.Scale:
                        return scaleValue;
                    case Transformation.TranslationX:
                        return translateXValue;
                    case Transformation.TranslationY:
                        return translateYValue;
                    default:
                        return new NumericUpDown();
                }
            } else if (type == typeof(CheckBox)) {
                switch (tf) {
                    case Transformation.Rotate:
                        return rotationCheckbox;
                    case Transformation.Scale:
                        return scaleCheckbox;
                    case Transformation.TranslationX:
                    case Transformation.TranslationY:
                        return translateCheckbox;
                    case Transformation.ReflectionX:
                        return reflectionXCheckbox;
                    case Transformation.ReflectionY:
                        return reflectionYCheckbox;
                    default:
                        return new CheckBox();
                }
            } else {
                return false;
            }
        }

        private decimal getValue(Transformation tf) =>
            (getTransformation(tf, typeof(NumericUpDown)) as NumericUpDown).Value;

        private bool getCheckedStatus() {
            foreach (Transformation tf in Enum.GetValues(typeof(Transformation))) {
                if ((getTransformation(tf, typeof(CheckBox)) as CheckBox).Checked)
                    return true;
            }
            return false;
        }

        private bool getCheckedStatus(Transformation tf) =>
            (getTransformation(tf, typeof(CheckBox)) as CheckBox).Checked;
    }
}
