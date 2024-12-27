namespace dichotomy_method
{
    partial class integralForm
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
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            upBorder = new TextBox();
            lowBorder = new TextBox();
            label1 = new Label();
            txtBoxFunction = new TextBox();
            label2 = new Label();
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            sortGroup = new GroupBox();
            label3 = new Label();
            txtBoxN = new TextBox();
            chkBoxTrapz = new CheckBox();
            chkBoxSimpson = new CheckBox();
            chkBoxRectangle = new CheckBox();
            groupBox1 = new GroupBox();
            rectangleResult = new TextBox();
            trapezoidResult = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            simpsonResult = new TextBox();
            chkBoxTrapViz = new CheckBox();
            chkBoxSimpsonViz = new CheckBox();
            chkBoxRecViz = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            txtBoxOxes = new TextBox();
            txtBoxAccuracy = new TextBox();
            label9 = new Label();
            menuStrip1.SuspendLayout();
            sortGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1062, 36);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(114, 30);
            toolStripTextBox1.Text = "Построить";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new Size(114, 30);
            toolStripTextBox2.Text = "Вычислить";
            toolStripTextBox2.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(240, 30);
            toolStripTextBox3.Text = "Оптимальное число разбиений";
            toolStripTextBox3.Click += toolStripTextBox3_Click;
            // 
            // upBorder
            // 
            upBorder.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            upBorder.Location = new Point(28, 47);
            upBorder.Name = "upBorder";
            upBorder.Size = new Size(50, 32);
            upBorder.TabIndex = 22;
            upBorder.Text = "4";
            // 
            // lowBorder
            // 
            lowBorder.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lowBorder.Location = new Point(28, 152);
            lowBorder.Name = "lowBorder";
            lowBorder.Size = new Size(50, 32);
            lowBorder.TabIndex = 23;
            lowBorder.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(32, 90);
            label1.Name = "label1";
            label1.Size = new Size(44, 53);
            label1.TabIndex = 24;
            label1.Text = "∫";
            // 
            // txtBoxFunction
            // 
            txtBoxFunction.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxFunction.Location = new Point(82, 110);
            txtBoxFunction.Name = "txtBoxFunction";
            txtBoxFunction.Size = new Size(110, 32);
            txtBoxFunction.TabIndex = 25;
            txtBoxFunction.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(198, 110);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 26;
            label2.Text = "dx";
            // 
            // pvGraph
            // 
            pvGraph.Location = new Point(418, 56);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = Cursors.Hand;
            pvGraph.Size = new Size(590, 632);
            pvGraph.TabIndex = 27;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // sortGroup
            // 
            sortGroup.Controls.Add(label3);
            sortGroup.Controls.Add(txtBoxN);
            sortGroup.Controls.Add(chkBoxTrapz);
            sortGroup.Controls.Add(chkBoxSimpson);
            sortGroup.Controls.Add(chkBoxRectangle);
            sortGroup.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sortGroup.Location = new Point(32, 249);
            sortGroup.Name = "sortGroup";
            sortGroup.Size = new Size(199, 239);
            sortGroup.TabIndex = 28;
            sortGroup.TabStop = false;
            sortGroup.Text = "Настройки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 157);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 29;
            label3.Text = "Число делений";
            // 
            // txtBoxN
            // 
            txtBoxN.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxN.Location = new Point(16, 184);
            txtBoxN.Name = "txtBoxN";
            txtBoxN.Size = new Size(50, 32);
            txtBoxN.TabIndex = 29;
            txtBoxN.Text = "5";
            // 
            // chkBoxTrapz
            // 
            chkBoxTrapz.AutoSize = true;
            chkBoxTrapz.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            chkBoxTrapz.Location = new Point(6, 74);
            chkBoxTrapz.Name = "chkBoxTrapz";
            chkBoxTrapz.Size = new Size(103, 27);
            chkBoxTrapz.TabIndex = 1;
            chkBoxTrapz.Text = "Трапеций";
            chkBoxTrapz.UseVisualStyleBackColor = true;
            // 
            // chkBoxSimpson
            // 
            chkBoxSimpson.AutoSize = true;
            chkBoxSimpson.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            chkBoxSimpson.Location = new Point(6, 106);
            chkBoxSimpson.Name = "chkBoxSimpson";
            chkBoxSimpson.Size = new Size(105, 27);
            chkBoxSimpson.TabIndex = 3;
            chkBoxSimpson.Text = "Симпсона";
            chkBoxSimpson.UseVisualStyleBackColor = true;
            // 
            // chkBoxRectangle
            // 
            chkBoxRectangle.AutoSize = true;
            chkBoxRectangle.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            chkBoxRectangle.Location = new Point(6, 41);
            chkBoxRectangle.Name = "chkBoxRectangle";
            chkBoxRectangle.Size = new Size(165, 27);
            chkBoxRectangle.TabIndex = 2;
            chkBoxRectangle.Text = "Прямоугольников";
            chkBoxRectangle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rectangleResult);
            groupBox1.Controls.Add(trapezoidResult);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(simpsonResult);
            groupBox1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(32, 501);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 187);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Результаты";
            // 
            // rectangleResult
            // 
            rectangleResult.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rectangleResult.Location = new Point(177, 50);
            rectangleResult.Name = "rectangleResult";
            rectangleResult.Size = new Size(109, 32);
            rectangleResult.TabIndex = 33;
            rectangleResult.Text = "0";
            // 
            // trapezoidResult
            // 
            trapezoidResult.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            trapezoidResult.Location = new Point(177, 89);
            trapezoidResult.Name = "trapezoidResult";
            trapezoidResult.Size = new Size(109, 32);
            trapezoidResult.TabIndex = 32;
            trapezoidResult.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 134);
            label6.Name = "label6";
            label6.Size = new Size(92, 24);
            label6.TabIndex = 31;
            label6.Text = "Симпсона:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 94);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 30;
            label5.Text = "Трапеций:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 53);
            label4.Name = "label4";
            label4.Size = new Size(153, 24);
            label4.TabIndex = 29;
            label4.Text = "Прямоугольников:";
            // 
            // simpsonResult
            // 
            simpsonResult.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            simpsonResult.Location = new Point(177, 128);
            simpsonResult.Name = "simpsonResult";
            simpsonResult.Size = new Size(109, 32);
            simpsonResult.TabIndex = 29;
            simpsonResult.Text = "0";
            // 
            // chkBoxTrapViz
            // 
            chkBoxTrapViz.AutoSize = true;
            chkBoxTrapViz.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            chkBoxTrapViz.Location = new Point(291, 323);
            chkBoxTrapViz.Name = "chkBoxTrapViz";
            chkBoxTrapViz.Size = new Size(18, 17);
            chkBoxTrapViz.TabIndex = 30;
            chkBoxTrapViz.UseVisualStyleBackColor = true;
            // 
            // chkBoxSimpsonViz
            // 
            chkBoxSimpsonViz.AutoSize = true;
            chkBoxSimpsonViz.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            chkBoxSimpsonViz.Location = new Point(291, 355);
            chkBoxSimpsonViz.Name = "chkBoxSimpsonViz";
            chkBoxSimpsonViz.Size = new Size(18, 17);
            chkBoxSimpsonViz.TabIndex = 32;
            chkBoxSimpsonViz.UseVisualStyleBackColor = true;
            // 
            // chkBoxRecViz
            // 
            chkBoxRecViz.AutoSize = true;
            chkBoxRecViz.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            chkBoxRecViz.Location = new Point(291, 290);
            chkBoxRecViz.Name = "chkBoxRecViz";
            chkBoxRecViz.Size = new Size(18, 17);
            chkBoxRecViz.TabIndex = 31;
            chkBoxRecViz.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(241, 253);
            label7.Name = "label7";
            label7.Size = new Size(127, 24);
            label7.TabIndex = 34;
            label7.Text = "Визуализация:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(28, 201);
            label8.Name = "label8";
            label8.Size = new Size(249, 24);
            label8.TabIndex = 35;
            label8.Text = "Число точек построения осей:";
            // 
            // txtBoxOxes
            // 
            txtBoxOxes.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxOxes.Location = new Point(283, 198);
            txtBoxOxes.Name = "txtBoxOxes";
            txtBoxOxes.Size = new Size(50, 32);
            txtBoxOxes.TabIndex = 30;
            txtBoxOxes.Text = "5";
            // 
            // txtBoxAccuracy
            // 
            txtBoxAccuracy.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxAccuracy.Location = new Point(274, 433);
            txtBoxAccuracy.Name = "txtBoxAccuracy";
            txtBoxAccuracy.Size = new Size(50, 32);
            txtBoxAccuracy.TabIndex = 36;
            txtBoxAccuracy.Text = "5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(264, 406);
            label9.Name = "label9";
            label9.Size = new Size(80, 24);
            label9.TabIndex = 37;
            label9.Text = "Точность";
            // 
            // integralForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 799);
            Controls.Add(label9);
            Controls.Add(txtBoxAccuracy);
            Controls.Add(txtBoxOxes);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(chkBoxTrapViz);
            Controls.Add(groupBox1);
            Controls.Add(chkBoxSimpsonViz);
            Controls.Add(sortGroup);
            Controls.Add(chkBoxRecViz);
            Controls.Add(pvGraph);
            Controls.Add(label2);
            Controls.Add(txtBoxFunction);
            Controls.Add(label1);
            Controls.Add(lowBorder);
            Controls.Add(upBorder);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "integralForm";
            Text = "integralForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            sortGroup.ResumeLayout(false);
            sortGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private TextBox upBorder;
        private TextBox lowBorder;
        private Label label1;
        private TextBox txtBoxFunction;
        private Label label2;
        private OxyPlot.WindowsForms.PlotView pvGraph;
        private GroupBox sortGroup;
        private Label label3;
        private TextBox txtBoxN;
        private CheckBox chkBoxTrapz;
        private CheckBox chkBoxSimpson;
        private CheckBox chkBoxRectangle;
        private GroupBox groupBox1;
        private TextBox rectangleResult;
        private TextBox trapezoidResult;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox simpsonResult;
        private CheckBox chkBoxTrapViz;
        private CheckBox chkBoxSimpsonViz;
        private CheckBox chkBoxRecViz;
        private Label label7;
        private Label label8;
        private TextBox txtBoxOxes;
        private TextBox txtBoxAccuracy;
        private Label label9;
        private ToolStripTextBox toolStripTextBox3;
    }
}