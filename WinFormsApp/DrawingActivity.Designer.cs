namespace WinFormsApp {
    partial class drawingActivity {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.drawingBoard = new System.Windows.Forms.PictureBox();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingBoard
            // 
            this.drawingBoard.BackColor = System.Drawing.Color.White;
            this.drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLayout.SetColumnSpan(this.drawingBoard, 2);
            this.drawingBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingBoard.Location = new System.Drawing.Point(3, 3);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(794, 409);
            this.drawingBoard.TabIndex = 0;
            this.drawingBoard.TabStop = false;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseDown);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.drawingBoard, 0, 0);
            this.mainLayout.Controls.Add(this.cleanBtn, 0, 1);
            this.mainLayout.Controls.Add(this.closeBtn, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainLayout.Size = new System.Drawing.Size(800, 450);
            this.mainLayout.TabIndex = 1;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanBtn.Location = new System.Drawing.Point(3, 418);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(394, 29);
            this.cleanBtn.TabIndex = 1;
            this.cleanBtn.Text = "Limpiar";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBtn.Location = new System.Drawing.Point(403, 418);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(394, 29);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Cerrar";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // drawingActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayout);
            this.Name = "drawingActivity";
            this.Text = "Lienzo de Dibujo";
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingBoard;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}