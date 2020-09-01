using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainActivity : Form
    {
        bool shouldReset = false;
        bool shouldScale = false;
        bool shouldTranslate = false;
        bool shouldRotate = false;

        float scaling;
        float translation;
        float rotation;

        public MainActivity()
        {
            InitializeComponent();
        }

        private void DrawingBox_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (shouldScale && scaling != 0)
            {
                e.Graphics.ScaleTransform(scaling, scaling);
                shouldScale = false;
            }

            if (shouldTranslate && translation != 0)
            {
                e.Graphics.TranslateTransform(translation, translation);
                shouldTranslate = false;
            }

            if (shouldRotate)
            {
                e.Graphics.RotateTransform(rotation);
                shouldRotate = false;
            }

            if (shouldReset)
            {
                e.Graphics.ResetTransform();
                shouldReset = false;
                shouldScale = false;
                shouldTranslate = false;
            }

            e.Graphics.DrawRectangle(myPen, new Rectangle(200, 200, 40, 40));
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            shouldReset = true;
            Refresh();
        }

        private void scaleBtn_Click(object sender, EventArgs e)
        {
            shouldScale = true;
            Refresh();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            shouldTranslate = true;
            Refresh();
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            shouldRotate = true;
            Refresh();
        }

        private void scaleTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(scaleTextBox.Text.ToString(), out scaling);
        }

        private void translateTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(translateTextBox.Text.ToString(), out translation);
        }

        private void rotateTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(rotateTextBox.Text.ToString(), out rotation);
        }
    }
}
