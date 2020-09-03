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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.optionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.coordsLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.TextBox();
            this.sizeXValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.TextBox();
            this.sizeYValue = new System.Windows.Forms.NumericUpDown();
            this.autoResizeCheckbox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rotationValue = new System.Windows.Forms.NumericUpDown();
            this.homothesisValue = new System.Windows.Forms.NumericUpDown();
            this.cleanTransformBtn = new System.Windows.Forms.Button();
            this.rotationCheckbox = new System.Windows.Forms.CheckBox();
            this.homothesisCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionXCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionYCheckbox = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.animationsCheckbox = new System.Windows.Forms.CheckBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayout.SuspendLayout();
            this.optionsLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeXValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeYValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homothesisValue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.mainTableLayout.Controls.Add(this.optionsLayout, 1, 0);
            this.mainTableLayout.Controls.Add(this.panel1, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayout.TabIndex = 0;
            // 
            // optionsLayout
            // 
            this.optionsLayout.AutoScroll = true;
            this.optionsLayout.ColumnCount = 1;
            this.optionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsLayout.Controls.Add(this.textBox2, 0, 8);
            this.optionsLayout.Controls.Add(this.coordsLabel, 0, 0);
            this.optionsLayout.Controls.Add(this.label1, 0, 1);
            this.optionsLayout.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.optionsLayout.Controls.Add(this.autoResizeCheckbox, 0, 3);
            this.optionsLayout.Controls.Add(this.textBox1, 0, 5);
            this.optionsLayout.Controls.Add(this.rotationValue, 0, 6);
            this.optionsLayout.Controls.Add(this.homothesisValue, 0, 9);
            this.optionsLayout.Controls.Add(this.cleanTransformBtn, 0, 14);
            this.optionsLayout.Controls.Add(this.rotationCheckbox, 0, 7);
            this.optionsLayout.Controls.Add(this.homothesisCheckbox, 0, 10);
            this.optionsLayout.Controls.Add(this.reflectionXCheckbox, 0, 12);
            this.optionsLayout.Controls.Add(this.reflectionYCheckbox, 0, 13);
            this.optionsLayout.Controls.Add(this.textBox3, 0, 11);
            this.optionsLayout.Controls.Add(this.textBox4, 0, 15);
            this.optionsLayout.Controls.Add(this.animationsCheckbox, 0, 16);
            this.optionsLayout.Controls.Add(this.cleanBtn, 0, 4);
            this.optionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsLayout.Location = new System.Drawing.Point(593, 3);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.RowCount = 18;
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.Size = new System.Drawing.Size(204, 444);
            this.optionsLayout.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 200);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(204, 10);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "---------------------------------------------------------------------\r\n";
            this.textBox2.WordWrap = false;
            // 
            // coordsLabel
            // 
            this.coordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coordsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coordsLabel.Location = new System.Drawing.Point(3, 3);
            this.coordsLabel.Multiline = true;
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.ReadOnly = true;
            this.coordsLabel.Size = new System.Drawing.Size(198, 29);
            this.coordsLabel.TabIndex = 1;
            this.coordsLabel.Text = "Coordenadas del mouse\r\n-";
            this.coordsLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(198, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño del lienzo";
            this.label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.sizeXValue);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.sizeYValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 25);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Multiline = true;
            this.label2.Name = "label2";
            this.label2.ReadOnly = true;
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ancho";
            this.label2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label2.WordWrap = false;
            // 
            // sizeXValue
            // 
            this.sizeXValue.Location = new System.Drawing.Point(49, 3);
            this.sizeXValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.sizeXValue.Name = "sizeXValue";
            this.sizeXValue.ReadOnly = true;
            this.sizeXValue.Size = new System.Drawing.Size(50, 20);
            this.sizeXValue.TabIndex = 4;
            this.sizeXValue.ValueChanged += new System.EventHandler(this.sizeValues_ValueChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label3.Location = new System.Drawing.Point(105, 3);
            this.label3.Multiline = true;
            this.label3.Name = "label3";
            this.label3.ReadOnly = true;
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alto";
            this.label3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label3.WordWrap = false;
            // 
            // sizeYValue
            // 
            this.sizeYValue.Location = new System.Drawing.Point(141, 3);
            this.sizeYValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.sizeYValue.Name = "sizeYValue";
            this.sizeYValue.ReadOnly = true;
            this.sizeYValue.Size = new System.Drawing.Size(50, 20);
            this.sizeYValue.TabIndex = 5;
            this.sizeYValue.ValueChanged += new System.EventHandler(this.sizeValues_ValueChanged);
            // 
            // autoResizeCheckbox
            // 
            this.autoResizeCheckbox.AutoSize = true;
            this.autoResizeCheckbox.Checked = true;
            this.autoResizeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoResizeCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoResizeCheckbox.Location = new System.Drawing.Point(3, 83);
            this.autoResizeCheckbox.Name = "autoResizeCheckbox";
            this.autoResizeCheckbox.Size = new System.Drawing.Size(198, 19);
            this.autoResizeCheckbox.TabIndex = 4;
            this.autoResizeCheckbox.Text = "Redimensionar automáticamente";
            this.autoResizeCheckbox.UseVisualStyleBackColor = true;
            this.autoResizeCheckbox.CheckedChanged += new System.EventHandler(this.autoResizeCheckbox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 10);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "---------------------------------------------------------------------\r\n";
            this.textBox1.WordWrap = false;
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
            this.rotationValue.Location = new System.Drawing.Point(3, 153);
            this.rotationValue.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.rotationValue.Name = "rotationValue";
            this.rotationValue.Size = new System.Drawing.Size(198, 20);
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
            this.homothesisValue.Location = new System.Drawing.Point(3, 213);
            this.homothesisValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.homothesisValue.Name = "homothesisValue";
            this.homothesisValue.Size = new System.Drawing.Size(198, 20);
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
            this.cleanTransformBtn.Location = new System.Drawing.Point(3, 323);
            this.cleanTransformBtn.Name = "cleanTransformBtn";
            this.cleanTransformBtn.Size = new System.Drawing.Size(198, 29);
            this.cleanTransformBtn.TabIndex = 13;
            this.cleanTransformBtn.Text = "Deshacer transformaciones";
            this.cleanTransformBtn.UseVisualStyleBackColor = true;
            this.cleanTransformBtn.Click += new System.EventHandler(this.cleanTransformBtn_Click);
            // 
            // rotationCheckbox
            // 
            this.rotationCheckbox.AutoSize = true;
            this.rotationCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationCheckbox.Location = new System.Drawing.Point(3, 178);
            this.rotationCheckbox.Name = "rotationCheckbox";
            this.rotationCheckbox.Size = new System.Drawing.Size(198, 19);
            this.rotationCheckbox.TabIndex = 14;
            this.rotationCheckbox.Text = "Aplicar ángulo de rotación";
            this.rotationCheckbox.UseVisualStyleBackColor = true;
            this.rotationCheckbox.CheckedChanged += new System.EventHandler(this.enableTransformations_Event);
            // 
            // homothesisCheckbox
            // 
            this.homothesisCheckbox.AutoSize = true;
            this.homothesisCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homothesisCheckbox.Location = new System.Drawing.Point(3, 238);
            this.homothesisCheckbox.Name = "homothesisCheckbox";
            this.homothesisCheckbox.Size = new System.Drawing.Size(198, 19);
            this.homothesisCheckbox.TabIndex = 15;
            this.homothesisCheckbox.Text = "Aplicar factor de homotecia";
            this.homothesisCheckbox.UseVisualStyleBackColor = true;
            this.homothesisCheckbox.CheckedChanged += new System.EventHandler(this.enableTransformations_Event);
            // 
            // reflectionXCheckbox
            // 
            this.reflectionXCheckbox.AutoSize = true;
            this.reflectionXCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionXCheckbox.Enabled = false;
            this.reflectionXCheckbox.Location = new System.Drawing.Point(3, 273);
            this.reflectionXCheckbox.Name = "reflectionXCheckbox";
            this.reflectionXCheckbox.Size = new System.Drawing.Size(198, 19);
            this.reflectionXCheckbox.TabIndex = 16;
            this.reflectionXCheckbox.Text = "Aplicar reflexión en X";
            this.reflectionXCheckbox.UseVisualStyleBackColor = true;
            // 
            // reflectionYCheckbox
            // 
            this.reflectionYCheckbox.AutoSize = true;
            this.reflectionYCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionYCheckbox.Enabled = false;
            this.reflectionYCheckbox.Location = new System.Drawing.Point(3, 298);
            this.reflectionYCheckbox.Name = "reflectionYCheckbox";
            this.reflectionYCheckbox.Size = new System.Drawing.Size(198, 19);
            this.reflectionYCheckbox.TabIndex = 17;
            this.reflectionYCheckbox.Text = "Aplicar reflexión en Y";
            this.reflectionYCheckbox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 260);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(204, 10);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "---------------------------------------------------------------------\r\n";
            this.textBox3.WordWrap = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(0, 355);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(204, 10);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "---------------------------------------------------------------------\r\n";
            this.textBox4.WordWrap = false;
            // 
            // animationsCheckbox
            // 
            this.animationsCheckbox.AutoSize = true;
            this.animationsCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationsCheckbox.Enabled = false;
            this.animationsCheckbox.Location = new System.Drawing.Point(3, 368);
            this.animationsCheckbox.Name = "animationsCheckbox";
            this.animationsCheckbox.Size = new System.Drawing.Size(198, 19);
            this.animationsCheckbox.TabIndex = 21;
            this.animationsCheckbox.Text = "Activar animaciones";
            this.animationsCheckbox.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(3, 108);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(198, 29);
            this.cleanBtn.TabIndex = 5;
            this.cleanBtn.Text = "Limpiar lienzo";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.drawingBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 444);
            this.panel1.TabIndex = 3;
            // 
            // drawingBox
            // 
            this.drawingBox.BackColor = System.Drawing.Color.White;
            this.drawingBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingBox.Location = new System.Drawing.Point(0, 0);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(584, 444);
            this.drawingBox.TabIndex = 1;
            this.drawingBox.TabStop = false;
            this.drawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBox_Click);
            this.drawingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseDown);
            this.drawingBox.MouseLeave += new System.EventHandler(this.drawingBox_MouseLeave);
            this.drawingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseMove);
            this.drawingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseUp);
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "MainActivity";
            this.Text = "Transformaciones lineales";
            this.Resize += new System.EventHandler(this.MainActivity_Resize);
            this.mainTableLayout.ResumeLayout(false);
            this.optionsLayout.ResumeLayout(false);
            this.optionsLayout.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeXValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeYValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homothesisValue)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.TableLayoutPanel optionsLayout;
        private System.Windows.Forms.TextBox coordsLabel;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox label2;
        private System.Windows.Forms.TextBox label3;
        private System.Windows.Forms.CheckBox autoResizeCheckbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown rotationValue;
        private System.Windows.Forms.NumericUpDown homothesisValue;
        private System.Windows.Forms.Button cleanTransformBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox rotationCheckbox;
        private System.Windows.Forms.CheckBox homothesisCheckbox;
        private System.Windows.Forms.CheckBox reflectionXCheckbox;
        private System.Windows.Forms.CheckBox reflectionYCheckbox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox animationsCheckbox;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.NumericUpDown sizeXValue;
        private System.Windows.Forms.NumericUpDown sizeYValue;
    }
}

