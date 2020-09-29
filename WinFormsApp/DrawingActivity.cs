using System;
using System.Windows.Forms;

namespace WinFormsApp {
    public partial class drawingActivity : Form {
        public drawingActivity() {
            InitializeComponent();
            drawingBoard.Cursor = new Cursor(AppDomain.CurrentDomain.BaseDirectory + "PenIcon.cur");
        }
    }
}
