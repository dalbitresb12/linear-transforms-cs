namespace WinFormsApp {
    partial class mainActivity {
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.optionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.openDrawingBtn = new System.Windows.Forms.Button();
            this.rotationValue = new System.Windows.Forms.NumericUpDown();
            this.homothesisValue = new System.Windows.Forms.NumericUpDown();
            this.cleanTransformBtn = new System.Windows.Forms.Button();
            this.rotationCheckbox = new System.Windows.Forms.CheckBox();
            this.homothesisCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionXCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionYCheckbox = new System.Windows.Forms.CheckBox();
            this.animationsCheckbox = new System.Windows.Forms.CheckBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.optionsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homothesisValue)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.mainTableLayout.Controls.Add(this.panel1, 0, 0);
            this.mainTableLayout.Controls.Add(this.optionsLayout, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.drawingBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 444);
            this.panel1.TabIndex = 3;
            // 
            // drawingBox
            // 
            this.drawingBox.BackColor = System.Drawing.Color.White;
            this.drawingBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.drawingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingBox.Location = new System.Drawing.Point(0, 0);
            this.drawingBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(574, 444);
            this.drawingBox.TabIndex = 1;
            this.drawingBox.TabStop = false;
            this.drawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBox_Paint);
            // 
            // optionsLayout
            // 
            this.optionsLayout.ColumnCount = 1;
            this.optionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.optionsLayout.Controls.Add(this.openDrawingBtn, 0, 0);
            this.optionsLayout.Controls.Add(this.rotationValue, 0, 2);
            this.optionsLayout.Controls.Add(this.homothesisValue, 0, 4);
            this.optionsLayout.Controls.Add(this.cleanTransformBtn, 0, 8);
            this.optionsLayout.Controls.Add(this.rotationCheckbox, 0, 3);
            this.optionsLayout.Controls.Add(this.homothesisCheckbox, 0, 5);
            this.optionsLayout.Controls.Add(this.reflectionXCheckbox, 0, 6);
            this.optionsLayout.Controls.Add(this.reflectionYCheckbox, 0, 7);
            this.optionsLayout.Controls.Add(this.animationsCheckbox, 0, 9);
            this.optionsLayout.Controls.Add(this.cleanBtn, 0, 1);
            this.optionsLayout.Location = new System.Drawing.Point(583, 3);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.RowCount = 10;
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.Size = new System.Drawing.Size(214, 444);
            this.optionsLayout.TabIndex = 2;
            // 
            // openDrawingBtn
            // 
            this.openDrawingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openDrawingBtn.Location = new System.Drawing.Point(3, 3);
            this.openDrawingBtn.Name = "openDrawingBtn";
            this.openDrawingBtn.Size = new System.Drawing.Size(208, 29);
            this.openDrawingBtn.TabIndex = 22;
            this.openDrawingBtn.Text = "Abrir dibujo";
            this.openDrawingBtn.UseVisualStyleBackColor = true;
            this.openDrawingBtn.Click += new System.EventHandler(this.openDrawingBtn_Click);
            // 
            // rotationValue
            // 
            this.rotationValue.DecimalPlaces = 2;
            this.rotationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rotationValue.Location = new System.Drawing.Point(3, 73);
            this.rotationValue.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.rotationValue.Name = "rotationValue";
            this.rotationValue.Size = new System.Drawing.Size(208, 20);
            this.rotationValue.TabIndex = 9;
            this.rotationValue.ValueChanged += new System.EventHandler(this.refreshScreen_Event);
            // 
            // homothesisValue
            // 
            this.homothesisValue.DecimalPlaces = 2;
            this.homothesisValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homothesisValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.homothesisValue.Location = new System.Drawing.Point(3, 123);
            this.homothesisValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.homothesisValue.Name = "homothesisValue";
            this.homothesisValue.Size = new System.Drawing.Size(208, 20);
            this.homothesisValue.TabIndex = 10;
            this.homothesisValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.homothesisValue.ValueChanged += new System.EventHandler(this.refreshScreen_Event);
            // 
            // cleanTransformBtn
            // 
            this.cleanTransformBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanTransformBtn.Location = new System.Drawing.Point(3, 223);
            this.cleanTransformBtn.Name = "cleanTransformBtn";
            this.cleanTransformBtn.Size = new System.Drawing.Size(208, 29);
            this.cleanTransformBtn.TabIndex = 13;
            this.cleanTransformBtn.Text = "Deshacer transformaciones";
            this.cleanTransformBtn.UseVisualStyleBackColor = true;
            this.cleanTransformBtn.Click += new System.EventHandler(this.cleanTransformBtn_Click);
            // 
            // rotationCheckbox
            // 
            this.rotationCheckbox.AutoSize = true;
            this.rotationCheckbox.Location = new System.Drawing.Point(3, 98);
            this.rotationCheckbox.Name = "rotationCheckbox";
            this.rotationCheckbox.Size = new System.Drawing.Size(149, 17);
            this.rotationCheckbox.TabIndex = 14;
            this.rotationCheckbox.Text = "Aplicar ángulo de rotación";
            this.rotationCheckbox.UseVisualStyleBackColor = true;
            // 
            // homothesisCheckbox
            // 
            this.homothesisCheckbox.AutoSize = true;
            this.homothesisCheckbox.Location = new System.Drawing.Point(3, 148);
            this.homothesisCheckbox.Name = "homothesisCheckbox";
            this.homothesisCheckbox.Size = new System.Drawing.Size(155, 17);
            this.homothesisCheckbox.TabIndex = 15;
            this.homothesisCheckbox.Text = "Aplicar factor de homotecia";
            this.homothesisCheckbox.UseVisualStyleBackColor = true;
            // 
            // reflectionXCheckbox
            // 
            this.reflectionXCheckbox.AutoSize = true;
            this.reflectionXCheckbox.Enabled = false;
            this.reflectionXCheckbox.Location = new System.Drawing.Point(3, 173);
            this.reflectionXCheckbox.Name = "reflectionXCheckbox";
            this.reflectionXCheckbox.Size = new System.Drawing.Size(125, 17);
            this.reflectionXCheckbox.TabIndex = 16;
            this.reflectionXCheckbox.Text = "Aplicar reflexión en X";
            this.reflectionXCheckbox.UseVisualStyleBackColor = true;
            // 
            // reflectionYCheckbox
            // 
            this.reflectionYCheckbox.AutoSize = true;
            this.reflectionYCheckbox.Enabled = false;
            this.reflectionYCheckbox.Location = new System.Drawing.Point(3, 198);
            this.reflectionYCheckbox.Name = "reflectionYCheckbox";
            this.reflectionYCheckbox.Size = new System.Drawing.Size(125, 17);
            this.reflectionYCheckbox.TabIndex = 17;
            this.reflectionYCheckbox.Text = "Aplicar reflexión en Y";
            this.reflectionYCheckbox.UseVisualStyleBackColor = true;
            // 
            // animationsCheckbox
            // 
            this.animationsCheckbox.AutoSize = true;
            this.animationsCheckbox.Enabled = false;
            this.animationsCheckbox.Location = new System.Drawing.Point(3, 258);
            this.animationsCheckbox.Name = "animationsCheckbox";
            this.animationsCheckbox.Size = new System.Drawing.Size(121, 17);
            this.animationsCheckbox.TabIndex = 21;
            this.animationsCheckbox.Text = "Activar animaciones";
            this.animationsCheckbox.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanBtn.Location = new System.Drawing.Point(3, 38);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(208, 29);
            this.cleanBtn.TabIndex = 5;
            this.cleanBtn.Text = "Cerrar dibujo";
            this.cleanBtn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Abrir dibujo";
            // 
            // mainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "mainActivity";
            this.Text = "Transformaciones lineales";
            this.Resize += new System.EventHandler(this.refreshScreen_Event);
            this.mainTableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.optionsLayout.ResumeLayout(false);
            this.optionsLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homothesisValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.TableLayoutPanel optionsLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown rotationValue;
        private System.Windows.Forms.NumericUpDown homothesisValue;
        private System.Windows.Forms.Button cleanTransformBtn;
        private System.Windows.Forms.CheckBox rotationCheckbox;
        private System.Windows.Forms.CheckBox homothesisCheckbox;
        private System.Windows.Forms.CheckBox reflectionXCheckbox;
        private System.Windows.Forms.CheckBox reflectionYCheckbox;
        private System.Windows.Forms.CheckBox animationsCheckbox;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button openDrawingBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}