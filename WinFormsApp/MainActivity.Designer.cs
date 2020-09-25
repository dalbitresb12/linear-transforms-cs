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
            this.homothesisValue = new System.Windows.Forms.NumericUpDown();
            this.cleanTransformBtn = new System.Windows.Forms.Button();
            this.rotationCheckbox = new System.Windows.Forms.CheckBox();
            this.homothesisCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionXCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionYCheckbox = new System.Windows.Forms.CheckBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.matrixLayout = new System.Windows.Forms.TableLayoutPanel();
            this.matrix11 = new System.Windows.Forms.TextBox();
            this.matrix12 = new System.Windows.Forms.TextBox();
            this.matrix22 = new System.Windows.Forms.TextBox();
            this.matrix21 = new System.Windows.Forms.TextBox();
            this.rotationValue = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.translateXValue = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.translateYValue = new System.Windows.Forms.NumericUpDown();
            this.translateCheckbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.matrix31 = new System.Windows.Forms.TextBox();
            this.matrix32 = new System.Windows.Forms.TextBox();
            this.matrix13 = new System.Windows.Forms.TextBox();
            this.matrix23 = new System.Windows.Forms.TextBox();
            this.matrix33 = new System.Windows.Forms.TextBox();
            this.mainTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.optionsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homothesisValue)).BeginInit();
            this.matrixLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateXValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYValue)).BeginInit();
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
            this.optionsLayout.Controls.Add(this.homothesisValue, 0, 6);
            this.optionsLayout.Controls.Add(this.cleanTransformBtn, 0, 10);
            this.optionsLayout.Controls.Add(this.rotationCheckbox, 0, 5);
            this.optionsLayout.Controls.Add(this.homothesisCheckbox, 0, 7);
            this.optionsLayout.Controls.Add(this.reflectionXCheckbox, 0, 8);
            this.optionsLayout.Controls.Add(this.reflectionYCheckbox, 0, 9);
            this.optionsLayout.Controls.Add(this.cleanBtn, 0, 1);
            this.optionsLayout.Controls.Add(this.matrixLayout, 0, 11);
            this.optionsLayout.Controls.Add(this.rotationValue, 0, 4);
            this.optionsLayout.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.optionsLayout.Controls.Add(this.translateCheckbox, 0, 3);
            this.optionsLayout.Location = new System.Drawing.Point(583, 3);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.RowCount = 12;
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.Size = new System.Drawing.Size(214, 444);
            this.optionsLayout.TabIndex = 2;
            // 
            // openDrawingBtn
            // 
            this.openDrawingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openDrawingBtn.Enabled = false;
            this.openDrawingBtn.Location = new System.Drawing.Point(3, 3);
            this.openDrawingBtn.Name = "openDrawingBtn";
            this.openDrawingBtn.Size = new System.Drawing.Size(208, 29);
            this.openDrawingBtn.TabIndex = 1;
            this.openDrawingBtn.Text = "Abrir dibujo";
            this.openDrawingBtn.UseVisualStyleBackColor = true;
            this.openDrawingBtn.Click += new System.EventHandler(this.openDrawingBtn_Click);
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
            this.homothesisValue.Location = new System.Drawing.Point(3, 173);
            this.homothesisValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.homothesisValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.homothesisValue.Name = "homothesisValue";
            this.homothesisValue.Size = new System.Drawing.Size(208, 20);
            this.homothesisValue.TabIndex = 7;
            this.homothesisValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.homothesisValue.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // cleanTransformBtn
            // 
            this.cleanTransformBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanTransformBtn.Location = new System.Drawing.Point(3, 273);
            this.cleanTransformBtn.Name = "cleanTransformBtn";
            this.cleanTransformBtn.Size = new System.Drawing.Size(208, 29);
            this.cleanTransformBtn.TabIndex = 11;
            this.cleanTransformBtn.Text = "Deshacer transformaciones";
            this.cleanTransformBtn.UseVisualStyleBackColor = true;
            this.cleanTransformBtn.Click += new System.EventHandler(this.cleanTransformBtn_Click);
            // 
            // rotationCheckbox
            // 
            this.rotationCheckbox.AutoSize = true;
            this.rotationCheckbox.Location = new System.Drawing.Point(3, 148);
            this.rotationCheckbox.Name = "rotationCheckbox";
            this.rotationCheckbox.Size = new System.Drawing.Size(149, 17);
            this.rotationCheckbox.TabIndex = 6;
            this.rotationCheckbox.Text = "Aplicar ángulo de rotación";
            this.rotationCheckbox.UseVisualStyleBackColor = true;
            this.rotationCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // homothesisCheckbox
            // 
            this.homothesisCheckbox.AutoSize = true;
            this.homothesisCheckbox.Location = new System.Drawing.Point(3, 198);
            this.homothesisCheckbox.Name = "homothesisCheckbox";
            this.homothesisCheckbox.Size = new System.Drawing.Size(155, 17);
            this.homothesisCheckbox.TabIndex = 8;
            this.homothesisCheckbox.Text = "Aplicar factor de homotecia";
            this.homothesisCheckbox.UseVisualStyleBackColor = true;
            this.homothesisCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // reflectionXCheckbox
            // 
            this.reflectionXCheckbox.AutoSize = true;
            this.reflectionXCheckbox.Location = new System.Drawing.Point(3, 223);
            this.reflectionXCheckbox.Name = "reflectionXCheckbox";
            this.reflectionXCheckbox.Size = new System.Drawing.Size(125, 17);
            this.reflectionXCheckbox.TabIndex = 9;
            this.reflectionXCheckbox.Text = "Aplicar reflexión en X";
            this.reflectionXCheckbox.UseVisualStyleBackColor = true;
            this.reflectionXCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // reflectionYCheckbox
            // 
            this.reflectionYCheckbox.AutoSize = true;
            this.reflectionYCheckbox.Location = new System.Drawing.Point(3, 248);
            this.reflectionYCheckbox.Name = "reflectionYCheckbox";
            this.reflectionYCheckbox.Size = new System.Drawing.Size(125, 17);
            this.reflectionYCheckbox.TabIndex = 10;
            this.reflectionYCheckbox.Text = "Aplicar reflexión en Y";
            this.reflectionYCheckbox.UseVisualStyleBackColor = true;
            this.reflectionYCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // cleanBtn
            // 
            this.cleanBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanBtn.Enabled = false;
            this.cleanBtn.Location = new System.Drawing.Point(3, 38);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(208, 29);
            this.cleanBtn.TabIndex = 2;
            this.cleanBtn.Text = "Cerrar dibujo";
            this.cleanBtn.UseVisualStyleBackColor = true;
            // 
            // matrixLayout
            // 
            this.matrixLayout.ColumnCount = 3;
            this.matrixLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.Controls.Add(this.matrix32, 0, 2);
            this.matrixLayout.Controls.Add(this.matrix31, 0, 2);
            this.matrixLayout.Controls.Add(this.matrix11, 0, 0);
            this.matrixLayout.Controls.Add(this.matrix12, 1, 0);
            this.matrixLayout.Controls.Add(this.matrix22, 1, 1);
            this.matrixLayout.Controls.Add(this.matrix21, 0, 1);
            this.matrixLayout.Controls.Add(this.matrix13, 2, 0);
            this.matrixLayout.Controls.Add(this.matrix23, 2, 1);
            this.matrixLayout.Controls.Add(this.matrix33, 2, 2);
            this.matrixLayout.Location = new System.Drawing.Point(3, 308);
            this.matrixLayout.Name = "matrixLayout";
            this.matrixLayout.RowCount = 3;
            this.matrixLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.Size = new System.Drawing.Size(208, 70);
            this.matrixLayout.TabIndex = 23;
            // 
            // matrix11
            // 
            this.matrix11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix11.Location = new System.Drawing.Point(3, 3);
            this.matrix11.Multiline = true;
            this.matrix11.Name = "matrix11";
            this.matrix11.ReadOnly = true;
            this.matrix11.Size = new System.Drawing.Size(63, 17);
            this.matrix11.TabIndex = 0;
            this.matrix11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix12
            // 
            this.matrix12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix12.Location = new System.Drawing.Point(72, 3);
            this.matrix12.Multiline = true;
            this.matrix12.Name = "matrix12";
            this.matrix12.ReadOnly = true;
            this.matrix12.Size = new System.Drawing.Size(63, 17);
            this.matrix12.TabIndex = 1;
            this.matrix12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix22
            // 
            this.matrix22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix22.Location = new System.Drawing.Point(72, 26);
            this.matrix22.Multiline = true;
            this.matrix22.Name = "matrix22";
            this.matrix22.ReadOnly = true;
            this.matrix22.Size = new System.Drawing.Size(63, 17);
            this.matrix22.TabIndex = 4;
            this.matrix22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix21
            // 
            this.matrix21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix21.Location = new System.Drawing.Point(3, 26);
            this.matrix21.Multiline = true;
            this.matrix21.Name = "matrix21";
            this.matrix21.ReadOnly = true;
            this.matrix21.Size = new System.Drawing.Size(63, 17);
            this.matrix21.TabIndex = 5;
            this.matrix21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rotationValue
            // 
            this.rotationValue.DecimalPlaces = 2;
            this.rotationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationValue.Location = new System.Drawing.Point(3, 123);
            this.rotationValue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationValue.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotationValue.Name = "rotationValue";
            this.rotationValue.Size = new System.Drawing.Size(208, 20);
            this.rotationValue.TabIndex = 5;
            this.rotationValue.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.translateXValue);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.translateYValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 25);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "X:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // translateXValue
            // 
            this.translateXValue.DecimalPlaces = 2;
            this.translateXValue.Location = new System.Drawing.Point(29, 3);
            this.translateXValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.translateXValue.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.translateXValue.Name = "translateXValue";
            this.translateXValue.Size = new System.Drawing.Size(70, 20);
            this.translateXValue.TabIndex = 3;
            this.translateXValue.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(105, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(20, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Y:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // translateYValue
            // 
            this.translateYValue.DecimalPlaces = 2;
            this.translateYValue.Location = new System.Drawing.Point(131, 3);
            this.translateYValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.translateYValue.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.translateYValue.Name = "translateYValue";
            this.translateYValue.Size = new System.Drawing.Size(70, 20);
            this.translateYValue.TabIndex = 5;
            this.translateYValue.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // translateCheckbox
            // 
            this.translateCheckbox.AutoSize = true;
            this.translateCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translateCheckbox.Location = new System.Drawing.Point(3, 98);
            this.translateCheckbox.Name = "translateCheckbox";
            this.translateCheckbox.Size = new System.Drawing.Size(208, 19);
            this.translateCheckbox.TabIndex = 25;
            this.translateCheckbox.Text = "Aplicar traslación";
            this.translateCheckbox.UseVisualStyleBackColor = true;
            this.translateCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Abrir dibujo";
            // 
            // matrix31
            // 
            this.matrix31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix31.Location = new System.Drawing.Point(3, 49);
            this.matrix31.Multiline = true;
            this.matrix31.Name = "matrix31";
            this.matrix31.ReadOnly = true;
            this.matrix31.Size = new System.Drawing.Size(63, 18);
            this.matrix31.TabIndex = 6;
            this.matrix31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix32
            // 
            this.matrix32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix32.Location = new System.Drawing.Point(72, 49);
            this.matrix32.Multiline = true;
            this.matrix32.Name = "matrix32";
            this.matrix32.ReadOnly = true;
            this.matrix32.Size = new System.Drawing.Size(63, 18);
            this.matrix32.TabIndex = 7;
            this.matrix32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix13
            // 
            this.matrix13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix13.Location = new System.Drawing.Point(141, 3);
            this.matrix13.Multiline = true;
            this.matrix13.Name = "matrix13";
            this.matrix13.ReadOnly = true;
            this.matrix13.Size = new System.Drawing.Size(64, 17);
            this.matrix13.TabIndex = 8;
            this.matrix13.Text = "0";
            this.matrix13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix23
            // 
            this.matrix23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix23.Location = new System.Drawing.Point(141, 26);
            this.matrix23.Multiline = true;
            this.matrix23.Name = "matrix23";
            this.matrix23.ReadOnly = true;
            this.matrix23.Size = new System.Drawing.Size(64, 17);
            this.matrix23.TabIndex = 9;
            this.matrix23.Text = "0";
            this.matrix23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix33
            // 
            this.matrix33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix33.Location = new System.Drawing.Point(141, 49);
            this.matrix33.Multiline = true;
            this.matrix33.Name = "matrix33";
            this.matrix33.ReadOnly = true;
            this.matrix33.Size = new System.Drawing.Size(64, 18);
            this.matrix33.TabIndex = 10;
            this.matrix33.Text = "1";
            this.matrix33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            ((System.ComponentModel.ISupportInitialize)(this.homothesisValue)).EndInit();
            this.matrixLayout.ResumeLayout(false);
            this.matrixLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateXValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYValue)).EndInit();
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
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button openDrawingBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel matrixLayout;
        private System.Windows.Forms.TextBox matrix11;
        private System.Windows.Forms.TextBox matrix12;
        private System.Windows.Forms.TextBox matrix22;
        private System.Windows.Forms.TextBox matrix21;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown translateXValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown translateYValue;
        private System.Windows.Forms.CheckBox translateCheckbox;
        private System.Windows.Forms.TextBox matrix32;
        private System.Windows.Forms.TextBox matrix31;
        private System.Windows.Forms.TextBox matrix13;
        private System.Windows.Forms.TextBox matrix23;
        private System.Windows.Forms.TextBox matrix33;
    }
}