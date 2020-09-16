using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp {
    public partial class mainActivity : Form {
        public mainActivity() {
            InitializeComponent();
            Refresh();
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e) {
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;

            Size drawingBoxSize = drawingBox.Size;
            GraphicsPath xAxis = new GraphicsPath();
            GraphicsPath yAxis = new GraphicsPath();
            xAxis.AddLine(new Point(-drawingBoxSize.Width, 0), new Point(drawingBoxSize.Width, 0));
            yAxis.AddLine(new Point(0, -drawingBoxSize.Height), new Point(0, drawingBoxSize.Height));

            world.TranslateTransform(drawingBoxSize.Width / 2, drawingBoxSize.Height / 2);
            world.RotateTransform(-90);
            world.DrawPath(new Pen(Color.Blue, 2), xAxis);
            world.DrawPath(new Pen(Color.Blue, 2), yAxis);
        }

        private void cleanTransformBtn_Click(object sender, EventArgs e) {
            rotationCheckbox.Checked = false;
            rotationValue.Value = 0;
            homothesisCheckbox.Checked = false;
            homothesisValue.Value = 1;
            reflectionXCheckbox.Checked = false;
            reflectionYCheckbox.Checked = false;
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
    }
}
