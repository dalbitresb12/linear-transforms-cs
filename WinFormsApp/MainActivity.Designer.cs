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
            this.scaleValue = new System.Windows.Forms.NumericUpDown();
            this.cleanTransformBtn = new System.Windows.Forms.Button();
            this.rotationCheckbox = new System.Windows.Forms.CheckBox();
            this.scaleCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionXCheckbox = new System.Windows.Forms.CheckBox();
            this.reflectionYCheckbox = new System.Windows.Forms.CheckBox();
            this.rotationValue = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.translateXValue = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.translateYValue = new System.Windows.Forms.NumericUpDown();
            this.translateCheckbox = new System.Windows.Forms.CheckBox();
            this.drawingToolStrip = new System.Windows.Forms.ToolStrip();
            this.cursorToolBtn = new System.Windows.Forms.ToolStripButton();
            this.eraserToolBtn = new System.Windows.Forms.ToolStripButton();
            this.dragToolBtn = new System.Windows.Forms.ToolStripButton();
            this.penToolBtn = new System.Windows.Forms.ToolStripButton();
            this.lineToolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.matrixLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.multipleViewCheckbox = new System.Windows.Forms.CheckBox();
            this.mainTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.optionsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateXValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYValue)).BeginInit();
            this.drawingToolStrip.SuspendLayout();
            this.matrixLayout.SuspendLayout();
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
            this.drawingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseDown);
            this.drawingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseMove);
            this.drawingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseUp);
            // 
            // optionsLayout
            // 
            this.optionsLayout.ColumnCount = 1;
            this.optionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.optionsLayout.Controls.Add(this.scaleValue, 0, 6);
            this.optionsLayout.Controls.Add(this.cleanTransformBtn, 0, 10);
            this.optionsLayout.Controls.Add(this.rotationCheckbox, 0, 5);
            this.optionsLayout.Controls.Add(this.scaleCheckbox, 0, 7);
            this.optionsLayout.Controls.Add(this.reflectionXCheckbox, 0, 8);
            this.optionsLayout.Controls.Add(this.reflectionYCheckbox, 0, 9);
            this.optionsLayout.Controls.Add(this.matrixLayout, 0, 11);
            this.optionsLayout.Controls.Add(this.rotationValue, 0, 4);
            this.optionsLayout.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.optionsLayout.Controls.Add(this.translateCheckbox, 0, 3);
            this.optionsLayout.Controls.Add(this.drawingToolStrip, 0, 0);
            this.optionsLayout.Controls.Add(this.multipleViewCheckbox, 0, 1);
            this.optionsLayout.Location = new System.Drawing.Point(583, 3);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.RowCount = 12;
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
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
            this.optionsLayout.Size = new System.Drawing.Size(214, 444);
            this.optionsLayout.TabIndex = 2;
            // 
            // scaleValue
            // 
            this.scaleValue.DecimalPlaces = 2;
            this.scaleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleValue.Location = new System.Drawing.Point(3, 158);
            this.scaleValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scaleValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.scaleValue.Name = "scaleValue";
            this.scaleValue.Size = new System.Drawing.Size(208, 20);
            this.scaleValue.TabIndex = 7;
            this.scaleValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleValue.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // cleanTransformBtn
            // 
            this.cleanTransformBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanTransformBtn.Location = new System.Drawing.Point(3, 258);
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
            this.rotationCheckbox.Location = new System.Drawing.Point(3, 133);
            this.rotationCheckbox.Name = "rotationCheckbox";
            this.rotationCheckbox.Size = new System.Drawing.Size(149, 17);
            this.rotationCheckbox.TabIndex = 6;
            this.rotationCheckbox.Text = "Aplicar ángulo de rotación";
            this.rotationCheckbox.UseVisualStyleBackColor = true;
            this.rotationCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // scaleCheckbox
            // 
            this.scaleCheckbox.AutoSize = true;
            this.scaleCheckbox.Location = new System.Drawing.Point(3, 183);
            this.scaleCheckbox.Name = "scaleCheckbox";
            this.scaleCheckbox.Size = new System.Drawing.Size(155, 17);
            this.scaleCheckbox.TabIndex = 8;
            this.scaleCheckbox.Text = "Aplicar factor de homotecia";
            this.scaleCheckbox.UseVisualStyleBackColor = true;
            this.scaleCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // reflectionXCheckbox
            // 
            this.reflectionXCheckbox.AutoSize = true;
            this.reflectionXCheckbox.Location = new System.Drawing.Point(3, 208);
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
            this.reflectionYCheckbox.Location = new System.Drawing.Point(3, 233);
            this.reflectionYCheckbox.Name = "reflectionYCheckbox";
            this.reflectionYCheckbox.Size = new System.Drawing.Size(125, 17);
            this.reflectionYCheckbox.TabIndex = 10;
            this.reflectionYCheckbox.Text = "Aplicar reflexión en Y";
            this.reflectionYCheckbox.UseVisualStyleBackColor = true;
            this.reflectionYCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // rotationValue
            // 
            this.rotationValue.DecimalPlaces = 2;
            this.rotationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationValue.Location = new System.Drawing.Point(3, 108);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
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
            this.translateCheckbox.Location = new System.Drawing.Point(3, 83);
            this.translateCheckbox.Name = "translateCheckbox";
            this.translateCheckbox.Size = new System.Drawing.Size(208, 19);
            this.translateCheckbox.TabIndex = 25;
            this.translateCheckbox.Text = "Aplicar traslación";
            this.translateCheckbox.UseVisualStyleBackColor = true;
            this.translateCheckbox.CheckedChanged += new System.EventHandler(this.applyTransformations_CheckedChanged);
            // 
            // drawingToolStrip
            // 
            this.drawingToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.drawingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursorToolBtn,
            this.eraserToolBtn,
            this.dragToolBtn,
            this.penToolBtn,
            this.lineToolBtn,
            this.toolStripSeparator1});
            this.drawingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.drawingToolStrip.Name = "drawingToolStrip";
            this.drawingToolStrip.Size = new System.Drawing.Size(214, 30);
            this.drawingToolStrip.TabIndex = 26;
            this.drawingToolStrip.Text = "Herramientas de dibujo";
            // 
            // cursorToolBtn
            // 
            this.cursorToolBtn.Checked = true;
            this.cursorToolBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cursorToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursorToolBtn.Image = global::WinFormsApp.Properties.Resources.CursorIcon;
            this.cursorToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cursorToolBtn.Name = "cursorToolBtn";
            this.cursorToolBtn.Size = new System.Drawing.Size(23, 27);
            this.cursorToolBtn.Text = "Cursor";
            this.cursorToolBtn.Click += new System.EventHandler(this.selectTool_Click);
            // 
            // eraserToolBtn
            // 
            this.eraserToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraserToolBtn.Image = global::WinFormsApp.Properties.Resources.EraserIcon;
            this.eraserToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraserToolBtn.Name = "eraserToolBtn";
            this.eraserToolBtn.Size = new System.Drawing.Size(23, 27);
            this.eraserToolBtn.Text = "Borrador";
            this.eraserToolBtn.Click += new System.EventHandler(this.selectTool_Click);
            // 
            // dragToolBtn
            // 
            this.dragToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dragToolBtn.Image = global::WinFormsApp.Properties.Resources.DragIcon;
            this.dragToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dragToolBtn.Name = "dragToolBtn";
            this.dragToolBtn.Size = new System.Drawing.Size(23, 27);
            this.dragToolBtn.Text = "Mover";
            this.dragToolBtn.Click += new System.EventHandler(this.selectTool_Click);
            // 
            // penToolBtn
            // 
            this.penToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penToolBtn.Image = global::WinFormsApp.Properties.Resources.PenIcon;
            this.penToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penToolBtn.Name = "penToolBtn";
            this.penToolBtn.Size = new System.Drawing.Size(23, 27);
            this.penToolBtn.Text = "Lápiz";
            this.penToolBtn.Click += new System.EventHandler(this.selectTool_Click);
            // 
            // lineToolBtn
            // 
            this.lineToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolBtn.Image = global::WinFormsApp.Properties.Resources.LineIcon;
            this.lineToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolBtn.Name = "lineToolBtn";
            this.lineToolBtn.Size = new System.Drawing.Size(23, 27);
            this.lineToolBtn.Text = "Línea";
            this.lineToolBtn.Click += new System.EventHandler(this.selectTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // matrixLayout
            // 
            this.matrixLayout.ColumnCount = 3;
            this.matrixLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.Controls.Add(this.label1, 0, 0);
            this.matrixLayout.Controls.Add(this.label2, 0, 1);
            this.matrixLayout.Controls.Add(this.label3, 0, 2);
            this.matrixLayout.Controls.Add(this.label4, 1, 0);
            this.matrixLayout.Controls.Add(this.label5, 1, 1);
            this.matrixLayout.Controls.Add(this.label6, 1, 2);
            this.matrixLayout.Controls.Add(this.label7, 2, 0);
            this.matrixLayout.Controls.Add(this.label8, 2, 1);
            this.matrixLayout.Controls.Add(this.label9, 2, 2);
            this.matrixLayout.Location = new System.Drawing.Point(3, 293);
            this.matrixLayout.Name = "matrixLayout";
            this.matrixLayout.RowCount = 3;
            this.matrixLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.matrixLayout.Size = new System.Drawing.Size(208, 70);
            this.matrixLayout.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(72, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(72, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(72, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(141, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(141, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(141, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multipleViewCheckbox
            // 
            this.multipleViewCheckbox.AutoSize = true;
            this.multipleViewCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipleViewCheckbox.Location = new System.Drawing.Point(3, 33);
            this.multipleViewCheckbox.Name = "multipleViewCheckbox";
            this.multipleViewCheckbox.Size = new System.Drawing.Size(208, 19);
            this.multipleViewCheckbox.TabIndex = 27;
            this.multipleViewCheckbox.Text = "Mostrar dibujo original";
            this.multipleViewCheckbox.UseVisualStyleBackColor = true;
            this.multipleViewCheckbox.CheckedChanged += new System.EventHandler(this.refreshScreen_Event);
            // 
            // mainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayout);
            this.KeyPreview = true;
            this.Name = "mainActivity";
            this.Text = "Transformaciones lineales";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainActivity_KeyDown);
            this.Resize += new System.EventHandler(this.refreshScreen_Event);
            this.mainTableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.optionsLayout.ResumeLayout(false);
            this.optionsLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationValue)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateXValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYValue)).EndInit();
            this.drawingToolStrip.ResumeLayout(false);
            this.drawingToolStrip.PerformLayout();
            this.matrixLayout.ResumeLayout(false);
            this.matrixLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.TableLayoutPanel optionsLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown rotationValue;
        private System.Windows.Forms.NumericUpDown scaleValue;
        private System.Windows.Forms.Button cleanTransformBtn;
        private System.Windows.Forms.CheckBox rotationCheckbox;
        private System.Windows.Forms.CheckBox scaleCheckbox;
        private System.Windows.Forms.CheckBox reflectionXCheckbox;
        private System.Windows.Forms.CheckBox reflectionYCheckbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown translateXValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown translateYValue;
        private System.Windows.Forms.CheckBox translateCheckbox;
        private System.Windows.Forms.ToolStrip drawingToolStrip;
        private System.Windows.Forms.ToolStripButton dragToolBtn;
        private System.Windows.Forms.ToolStripButton penToolBtn;
        private System.Windows.Forms.ToolStripButton cursorToolBtn;
        private System.Windows.Forms.ToolStripButton lineToolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton eraserToolBtn;
        private System.Windows.Forms.TableLayoutPanel matrixLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox multipleViewCheckbox;
    }
}