using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp {
    public partial class drawingActivity : Form {
        public readonly List<Point> pathPoints = new List<Point>();
        private readonly mainActivity parentForm;

        public drawingActivity(mainActivity parentForm) {
            InitializeComponent();
            this.parentForm = parentForm;
            drawingBoard.Cursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "PenIcon.cur");
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e) {
            Graphics world = e.Graphics;
            world.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();

            if (pathPoints.Count == 1) {
                path.AddRectangle(new Rectangle(pathPoints[0].X, pathPoints[0].Y, 1, 1));
            } else if (pathPoints.Count > 0) {
                path.AddLines(pathPoints.ToArray());
            }

            world.DrawPath(new Pen(Color.Black, 2), path);
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e) {
            pathPoints.Add(e.Location);
            // parentForm.handleChildValues();
            Refresh();
        }

        private void cleanBtn_Click(object sender, EventArgs e) {
            pathPoints.Clear();
            // parentForm.handleChildValues();
            Refresh();
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            // parentForm.handleChildValues();
            Hide();
        }
    }
}
