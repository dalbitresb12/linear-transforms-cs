namespace WinFormsApp
{
    partial class MainActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DrawingBox = new System.Windows.Forms.PictureBox();
            this.scaleBtn = new System.Windows.Forms.Button();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.rotateTextBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBox)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.DrawingBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DrawingBox
            // 
            this.DrawingBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingBox.Location = new System.Drawing.Point(3, 3);
            this.DrawingBox.Name = "DrawingBox";
            this.DrawingBox.Size = new System.Drawing.Size(594, 444);
            this.DrawingBox.TabIndex = 1;
            this.DrawingBox.TabStop = false;
            this.DrawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingBox_Paint);
            // 
            // scaleBtn
            // 
            this.scaleBtn.Location = new System.Drawing.Point(3, 3);
            this.scaleBtn.Name = "scaleBtn";
            this.scaleBtn.Size = new System.Drawing.Size(75, 23);
            this.scaleBtn.TabIndex = 1;
            this.scaleBtn.Text = "Scale";
            this.scaleBtn.UseVisualStyleBackColor = true;
            this.scaleBtn.Click += new System.EventHandler(this.scaleBtn_Click);
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(84, 3);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(100, 20);
            this.scaleTextBox.TabIndex = 3;
            this.scaleTextBox.TextChanged += new System.EventHandler(this.scaleTextBox_TextChanged);
            // 
            // translateBtn
            // 
            this.translateBtn.Location = new System.Drawing.Point(3, 32);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(75, 23);
            this.translateBtn.TabIndex = 4;
            this.translateBtn.Text = "Translate";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // translateTextBox
            // 
            this.translateTextBox.Location = new System.Drawing.Point(84, 32);
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.Size = new System.Drawing.Size(100, 20);
            this.translateTextBox.TabIndex = 5;
            this.translateTextBox.TextChanged += new System.EventHandler(this.translateTextBox_TextChanged);
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(3, 61);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(75, 23);
            this.rotateBtn.TabIndex = 6;
            this.rotateBtn.Text = "Rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // rotateTextBox
            // 
            this.rotateTextBox.Location = new System.Drawing.Point(84, 61);
            this.rotateTextBox.Name = "rotateTextBox";
            this.rotateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rotateTextBox.TabIndex = 7;
            this.rotateTextBox.TextChanged += new System.EventHandler(this.rotateTextBox_TextChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.Location = new System.Drawing.Point(3, 90);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.scaleBtn);
            this.flowLayoutPanel2.Controls.Add(this.scaleTextBox);
            this.flowLayoutPanel2.Controls.Add(this.translateBtn);
            this.flowLayoutPanel2.Controls.Add(this.translateTextBox);
            this.flowLayoutPanel2.Controls.Add(this.rotateBtn);
            this.flowLayoutPanel2.Controls.Add(this.rotateTextBox);
            this.flowLayoutPanel2.Controls.Add(this.resetBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(603, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(194, 444);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainActivity";
            this.Text = "Graphics Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBox)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox DrawingBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button scaleBtn;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.TextBox translateTextBox;
        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.TextBox rotateTextBox;
        private System.Windows.Forms.Button resetBtn;
    }
}

