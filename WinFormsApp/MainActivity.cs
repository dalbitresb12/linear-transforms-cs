using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp {
    public partial class mainActivity : Form {
        private bool shouldDraw = true;
        private bool transformationsEnabled = false;
        private decimal rotationAngle;
        private decimal homothesis;
        private readonly List<Point> pathPoints = new List<Point>() {
            new Point(0, 0),
            new Point(60, 60),
            new Point(60, 40),
            new Point(40, 60),
            new Point(60, 60)
        };

        public mainActivity() {
            InitializeComponent();

            rotationAngle = rotationValue.Value;
            homothesis = homothesisValue.Value;

            Refresh();
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e) {
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;

            Size drawingBoxSize = drawingBox.Size;
            GraphicsPath xAxis = new GraphicsPath();
            GraphicsPath yAxis = new GraphicsPath();
            GraphicsPath path = new GraphicsPath();

            xAxis.AddLine(new Point(-drawingBoxSize.Width, 0), new Point(drawingBoxSize.Width, 0));
            yAxis.AddLine(new Point(0, -drawingBoxSize.Height), new Point(0, drawingBoxSize.Height));

            if (pathPoints.Count > 0)
                path.AddLines(pathPoints.ToArray());

            Matrix tf = new Matrix();

            if (transformationsEnabled) {
                if (reflectionXCheckbox.Checked)
                    tf.Multiply(new Matrix(1, 0, 0, -1, 0, 0), MatrixOrder.Append);

                if (reflectionYCheckbox.Checked)
                    tf.Multiply(new Matrix(-1, 0, 0, 1, 0, 0), MatrixOrder.Append);

                if (rotationCheckbox.Checked)
                    tf.Rotate(-(float)rotationAngle, MatrixOrder.Append);

                if (homothesisCheckbox.Checked)
                    tf.Scale((float)homothesis, (float)homothesis, MatrixOrder.Append);
                
                path.Transform(tf);
            }

            showMatrix(tf);

            world.TranslateTransform(drawingBoxSize.Width / 2, drawingBoxSize.Height / 2);
            world.DrawPath(new Pen(Color.Blue, 2), xAxis);
            world.DrawPath(new Pen(Color.Blue, 2), yAxis);

            if (pathPoints.Count > 0 && shouldDraw)
                world.DrawPath(new Pen(Color.Black, 2), path);
        }

        private void showMatrix(Matrix matrix) {
            List<float> matrixValues = matrix.Elements.ToList();
            matrix11.Text = matrixValues[0].ToString();
            matrix12.Text = matrixValues[1].ToString();
            matrix21.Text = matrixValues[2].ToString();
            matrix22.Text = matrixValues[3].ToString();
        }

        private void refreshScreen_Event(object sender, EventArgs e) =>
            Refresh();

        private void openDrawingBtn_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string rawJson = System.IO.File.ReadAllText(@openFileDialog.FileName);
                JsonDocumentOptions options = new JsonDocumentOptions {
                    AllowTrailingCommas = true,
                    CommentHandling = JsonCommentHandling.Skip,
                };

                using (JsonDocument parsedJson = JsonDocument.Parse(rawJson, options)) {
                    JsonElement root = parsedJson.RootElement;
                    JsonElement canvasSize = root.GetProperty("canvasSize");
                    JsonElement pointCoords = root.GetProperty("points");
                }
            }
        }

        private void numeric_ValueChanged(object sender, EventArgs e) {
            NumericUpDown textBox = (NumericUpDown)sender;
            switch (textBox.Name) {
                case "rotationValue":
                    if (textBox.Value > (decimal)359.9 || textBox.Value < (decimal)-359.9)
                        textBox.Value = 0;
                    rotationAngle = textBox.Value;

                    if (rotationCheckbox.Checked)
                        Refresh();
                    break;
                case "homothesisValue":
                    if (textBox.Value == 0)
                        shouldDraw = false;
                    else
                        shouldDraw = true;
                    homothesis = textBox.Value;

                    if (homothesisCheckbox.Checked)
                        Refresh();
                    break;
            }
        }

        private void applyTransformations_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked && !transformationsEnabled) {
                transformationsEnabled = true;
            } else if (transformationsEnabled && !rotationCheckbox.Checked && !homothesisCheckbox.Checked && !reflectionXCheckbox.Checked && !reflectionYCheckbox.Checked) {
                transformationsEnabled = false;
            }
            Refresh();
        }

        private void cleanTransformBtn_Click(object sender, EventArgs e) {
            transformationsEnabled = false;
            reflectionXCheckbox.Checked = false;
            reflectionYCheckbox.Checked = false;
            rotationCheckbox.Checked = false;
            rotationValue.Value = 0;
            homothesisCheckbox.Checked = false;
            homothesisValue.Value = 1;
        }
    }
}
