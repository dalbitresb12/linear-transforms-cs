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
        Line
    }

    enum Transformation {
        Rotate,
        Scale,
        TranslationX,
        TranslationY,
        ReflectionX,
        ReflectionY
    }

    public partial class mainActivity : Form {
        private readonly Cursor penCursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "Cursors\\PenCursor.cur");
        private readonly Cursor dragCursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "Cursors\\DragCursor.cur");

        private Tool currentTool = Tool.Cursor;

        private readonly List<Point> pathPoints = new List<Point>();

        public mainActivity() =>
            InitializeComponent();

        private void drawingBox_Paint(object sender, PaintEventArgs e) {
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;

            bool transformationsEnabled = getCheckedStatus();
            decimal rotationAngle = getValue(Transformation.Rotate);
            decimal homothesis = getValue(Transformation.Scale);
            decimal translateX = getValue(Transformation.TranslationX);
            decimal translateY = getValue(Transformation.TranslationY);

            Size drawingBoxSize = drawingBox.Size;
            GraphicsPath xAxis = new GraphicsPath();
            GraphicsPath yAxis = new GraphicsPath();
            GraphicsPath path = new GraphicsPath();

            xAxis.AddLine(new Point(-drawingBoxSize.Width, 0), new Point(drawingBoxSize.Width, 0));
            yAxis.AddLine(new Point(0, -drawingBoxSize.Height), new Point(0, drawingBoxSize.Height));

            if (pathPoints != null && pathPoints.Count > 0)
                path.AddLines(pathPoints.ToArray());

            Matrix tf = new Matrix();

            if (pathPoints != null && pathPoints.Count > 0 && transformationsEnabled) {
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

            world.TranslateTransform(drawingBoxSize.Width / 2, drawingBoxSize.Height / 2);
            world.DrawPath(new Pen(Color.Black, 1), xAxis);
            world.DrawPath(new Pen(Color.Black, 1), yAxis);

            if (pathPoints != null && pathPoints.Count > 0) {
                world.DrawPath(new Pen(Color.Green, 2), path);

                if (transformationsEnabled && getValue(Transformation.Scale) != 0) {
                    path.Transform(tf);
                    world.DrawPath(new Pen(Color.Blue, 2), path);
                }
            }
        }

        private void drawingBox_MouseDown(object sender, MouseEventArgs e) {
            if (currentTool == Tool.Pen) {
                Size drawingBoxSize = drawingBox.Size;
                Point mouseLocation = new Point(e.Location.X, e.Location.Y);
                mouseLocation.X -= drawingBoxSize.Width / 2;
                mouseLocation.Y -= drawingBoxSize.Height / 2;
                pathPoints.Add(mouseLocation);
                Refresh();
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
                case Tool.Cursor:
                default:
                    return cursorToolBtn;
            }
        }

        private Tool getToolFromBtn(ToolStripButton btn) {
            if (btn == dragToolBtn)
                return Tool.Drag;
            else if (btn == penToolBtn)
                return Tool.Pen;
            else
                return Tool.Cursor;
        }

        private Cursor getToolCursor(Tool tool) {
            switch (tool) {
                case Tool.Drag:
                    return dragCursor;
                case Tool.Pen:
                    return penCursor;
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
                        return homothesisValue;
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
                        return homothesisCheckbox;
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
