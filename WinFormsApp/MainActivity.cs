using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp {
    enum Tool {
        None,
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
        private readonly Cursor penCursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "PenIcon.cur");

        private Tool currentTool = Tool.None;

        private readonly List<Point> pathPoints = new List<Point>();
        private bool shouldDraw = true;

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

                if (transformationsEnabled && shouldDraw) {
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
            List<float> matrixValues = matrix.Elements.ToList();
            matrix11.Text = matrixValues[0].ToString();
            matrix12.Text = matrixValues[1].ToString();
            matrix21.Text = matrixValues[2].ToString();
            matrix22.Text = matrixValues[3].ToString();
            matrix31.Text = matrixValues[4].ToString();
            matrix32.Text = matrixValues[5].ToString();
        }

        private void refreshScreen_Event(object sender, EventArgs e) =>
            Refresh();

        private void numeric_ValueChanged(object sender, EventArgs e) {
            bool checkedStatus;
            NumericUpDown textBox = sender as NumericUpDown;

            switch (textBox.Name) {
                case "rotationValue":
                    if (textBox.Value > (decimal)359.9 || textBox.Value < (decimal)-359.9)
                        textBox.Value = 0;

                    checkedStatus = getCheckedStatus(Transformation.Rotate);
                    break;
                case "homothesisValue":
                    if (textBox.Value == 0)
                        shouldDraw = false;
                    else
                        shouldDraw = true;

                    checkedStatus = getCheckedStatus(Transformation.Scale);
                    break;
                case "translateXValue":
                    checkedStatus = getCheckedStatus(Transformation.TranslationX);
                    break;
                case "translateYValue":
                    checkedStatus = getCheckedStatus(Transformation.TranslationY);
                    break;
                default:
                    checkedStatus = false;
                    break;
            }

            if (checkedStatus)
                Refresh();
        }

        private void applyTransformations_CheckedChanged(object sender, EventArgs e) {
            if (getCheckedStatus()) {
                editCheckbox.Enabled = false;
                editCheckbox.Checked = false;
            } else {
                editCheckbox.Enabled = true;
            }
            Refresh();
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


        private void cleanTransformBtn_Click(object sender, EventArgs e) {
            foreach (Transformation tf in Enum.GetValues(typeof(Transformation))) {
                (getTransformation(tf, typeof(CheckBox)) as CheckBox).Checked = false;
            }

            (getTransformation(Transformation.Rotate, typeof(NumericUpDown)) as NumericUpDown).Value = 0;
            (getTransformation(Transformation.Scale, typeof(NumericUpDown)) as NumericUpDown).Value = 1;
            (getTransformation(Transformation.TranslationX, typeof(NumericUpDown)) as NumericUpDown).Value = 0;
            (getTransformation(Transformation.TranslationY, typeof(NumericUpDown)) as NumericUpDown).Value = 0;

            editCheckbox.Enabled = true;
        }

        private void editCheckbox_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) {
                currentTool = Tool.Pen;
                drawingBox.Cursor = penCursor;
            } else {
                currentTool = Tool.None;
                drawingBox.Cursor = Cursors.Default;
            }
        }
    }
}
