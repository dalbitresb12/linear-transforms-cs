using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

struct Stroke
{
    public List<Point> strokes;
    public Color color;
}

namespace WinFormsApp
{
    public partial class MainActivity : Form
    {
        private bool isDrawing = false;
        private readonly List<Stroke> strokes = new List<Stroke>();
        private Stroke currStroke;

        public MainActivity()
        {
            InitializeComponent();
            sizeXTextBox.Text = drawingBox.Size.Width.ToString();
            sizeYTextBox.Text = drawingBox.Size.Height.ToString();
        }

        private void drawingBox_Click(object sender, PaintEventArgs e)
        {
            GraphicsPath path;
            Matrix transformations = new Matrix();
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;

            if (rotationCheckbox.Checked)
            {
                transformations.Rotate(Convert.ToSingle(rotationValue.Value));
            }

            if (homothesisCheckbox.Checked)
            {
                transformations.Scale(Convert.ToSingle(homothesisValue.Value), Convert.ToSingle(homothesisValue.Value));
            }

            foreach (Stroke stroke in strokes.Where(x => x.strokes.Count > 1))
            {
                path = new GraphicsPath();
                path.AddLines(stroke.strokes.ToArray());
                path.Transform(transformations);
                world.DrawPath(new Pen(stroke.color, 2), path);
            }
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                colorBtn.BackColor = colorSelector.Color;
                if (colorSelector.Color == Color.Black)
                {
                    colorBtn.ForeColor = Color.White;
                }
                else
                {
                    colorBtn.ForeColor = Color.Black;
                }
            }
        }

        private void drawingBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            currStroke = new Stroke
            {
                strokes = new List<Point>
            {
                e.Location
            },
                color = colorSelector.Color
            };
            strokes.Add(currStroke);
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currStroke.strokes.Add(e.Location);
                Refresh();
            }

            coordsLabel.Text = "Coordenadas del mouse" + Environment.NewLine + $"X: {e.Location.X} - Y: {e.Location.Y}";
        }

        private void drawingBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void sizeXTextBox_TextChanged(object sender, EventArgs e)
        {
            Size size = drawingBox.Size;
            if (Int32.TryParse(sizeXTextBox.Text, out int width))
            {
                size.Width = width;
                drawingBox.Size = size;
            }
            Refresh();
        }

        private void sizeYTextBox_TextChanged(object sender, EventArgs e)
        {
            Size size = drawingBox.Size;
            if (Int32.TryParse(sizeYTextBox.Text, out int height))
            {
                size.Height = height;
                drawingBox.Size = size;
            }
            Refresh();
        }

        private void MainActivity_Resize(object sender, EventArgs e)
        {
            sizeXTextBox.Text = drawingBox.Size.Width.ToString();
            sizeYTextBox.Text = drawingBox.Size.Height.ToString();
            Refresh();
        }

        private void autoResizeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Size size;
            if (autoResizeCheckbox.Checked)
            {
                sizeXTextBox.ReadOnly = true;
                sizeYTextBox.ReadOnly = true;
                drawingBox.Dock = DockStyle.Fill;
            }
            else
            {
                sizeXTextBox.ReadOnly = false;
                sizeYTextBox.ReadOnly = false;

                size = drawingBox.Size;
                drawingBox.Dock = DockStyle.None;
                drawingBox.Size = size;
            }

            sizeXTextBox.Text = drawingBox.Size.Width.ToString();
            sizeYTextBox.Text = drawingBox.Size.Height.ToString();
        }

        private void drawingBox_MouseLeave(object sender, EventArgs e)
        {
            coordsLabel.Text = "Coordenadas del mouse" + Environment.NewLine + "-";
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            strokes.RemoveAll(x => true);
            Refresh();
        }

        private void cleanTransformBtn_Click(object sender, EventArgs e)
        {
            rotationCheckbox.Checked = false;
            rotationValue.Value = 0;
            homothesisCheckbox.Checked = false;
            homothesisValue.Value = 1;
            reflectionXCheckbox.Checked = false;
            reflectionYCheckbox.Checked = false;
        }

        private void refreshScreen(object sender, EventArgs e)
        {
            Refresh();
        }

        private decimal easeInOutQuad(decimal t, decimal b, decimal c, decimal d)
        {
            if ((t /= d / 2) < 1) return c / 2 * t * t + b;
            return -c / 2 * ((--t) * (t - 2) - 1) + b;
        }
    }
}
