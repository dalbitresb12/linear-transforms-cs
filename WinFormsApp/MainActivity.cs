using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainActivity : Form
    {
        private bool isDrawing = false;
        private bool transformationsEnabled = false;
        private readonly List<List<Point>> strokes = new List<List<Point>>();
        private List<Point> currStroke;

        public MainActivity()
        {
            InitializeComponent();
            refreshSizeValues_Helper();
        }

        private void drawingBox_Click(object sender, PaintEventArgs e)
        {
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;
            
            GraphicsPath path = new GraphicsPath();
            foreach (List<Point> stroke in strokes.Where(x => x.Count >1))
            {
                GraphicsPath g = new GraphicsPath();
                g.AddLines(stroke.ToArray());
                path.AddPath(g, false);
            }

            if (transformationsEnabled)
            {
                Matrix transforms = new Matrix();
                RectangleF boundRect = path.GetBounds();
                //transforms.Translate(-(boundRect.Width / 2), -(boundRect.Height / 2));
                if (rotationCheckbox.Checked)
                {
                    transforms.RotateAt(Convert.ToSingle(rotationValue.Value), new Point((int)(boundRect.Width / 2), (int)(boundRect.Height / 2)), MatrixOrder.Append);
                }

                if (homothesisCheckbox.Checked)
                {
                    transforms.Scale(Convert.ToSingle(homothesisValue.Value), Convert.ToSingle(homothesisValue.Value), MatrixOrder.Append);
                }
                //transforms.Translate(boundRect.Width / 2, boundRect.Height / 2);
                foreach (decimal x in transforms.Elements)
                {
                    Debug.Write(x.ToString() + " ");
                }
                Debug.Write(Environment.NewLine);

                path.Transform(transforms);
            }

            world.DrawPath(new Pen(Color.Black, 2), path);
        }

        private void drawingBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!transformationsEnabled)
            {
                isDrawing = true;
                currStroke = new List<Point>();
                strokes.Add(currStroke);
            }
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currStroke.Add(e.Location);
                Refresh();
            }

            coordsLabel.Text = "Coordenadas del mouse" + Environment.NewLine + $"X: {e.Location.X} - Y: {e.Location.Y}";
        }

        private void drawingBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void sizeValues_ValueChanged(object sender, EventArgs e)
        {
            Size size = drawingBox.Size;
            size.Width = (int)sizeXValue.Value;
            size.Height = (int)sizeYValue.Value;
            drawingBox.Size = size;
            Refresh();
        }

        private void refreshSizeValues_Helper()
        {
            sizeXValue.Value = drawingBox.Size.Width;
            sizeYValue.Value = drawingBox.Size.Height;
        }

        private void MainActivity_Resize(object sender, EventArgs e)
        {
            refreshSizeValues_Helper();
            Refresh();
        }

        private void autoResizeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Size size;
            if (autoResizeCheckbox.Checked)
            {
                sizeXValue.ReadOnly = true;
                sizeYValue.ReadOnly = true;
                drawingBox.Dock = DockStyle.Fill;
            }
            else
            {
                sizeXValue.ReadOnly = false;
                sizeYValue.ReadOnly = false;

                size = drawingBox.Size;
                drawingBox.Dock = DockStyle.None;
                drawingBox.Size = size;
            }

            refreshSizeValues_Helper();
            Refresh();
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
            transformationsEnabled = false;
            rotationCheckbox.Checked = false;
            rotationValue.Value = 0;
            homothesisCheckbox.Checked = false;
            homothesisValue.Value = 1;
            reflectionXCheckbox.Checked = false;
            reflectionYCheckbox.Checked = false;
            drawingBox.Cursor = Cursors.Hand;
        }

        private void enableTransformations_Event(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                transformationsEnabled = true;
                drawingBox.Cursor = Cursors.No;
            }
            else
            {
                transformationsEnabled = false;
                drawingBox.Cursor = Cursors.Hand;
            }
            Refresh();
        }

        private void refreshScreen_Event(object sender, EventArgs e)
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
