namespace dichotomy_method
{
    partial class coordinateDescentForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBoxFunctionLimit = new TextBox();
            label1 = new Label();
            lblLimitation = new Label();
            lblEpsilon = new Label();
            txtBoxInterval = new TextBox();
            txtBox = new TextBox();
            txtBoxLimitation = new TextBox();
            txtBoxEpsilon = new TextBox();
            lblText1 = new Label();
            lblFunction = new Label();
            txtBoxSecondIntervalLim = new TextBox();
            txtBoxFirstIntervalLim = new TextBox();
            txtBoxFunction = new TextBox();
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            label7 = new Label();
            txtBoxIteration = new TextBox();
            groupBox1 = new GroupBox();
            rbtn3 = new RadioButton();
            rbtn2 = new RadioButton();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label4.Location = new Point(11, 310);
            label4.Name = "label4";
            label4.Size = new Size(236, 23);
            label4.TabIndex = 37;
            label4.Text = "Количество точек построения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label3.Location = new Point(12, 346);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 35;
            label3.Text = "осей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label2.Location = new Point(11, 479);
            label2.Name = "label2";
            label2.Size = new Size(266, 23);
            label2.TabIndex = 34;
            label2.Text = "функции (отрицательная сторона)";
            // 
            // txtBoxFunctionLimit
            // 
            txtBoxFunctionLimit.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunctionLimit.Location = new Point(11, 507);
            txtBoxFunctionLimit.Margin = new Padding(3, 4, 3, 4);
            txtBoxFunctionLimit.Name = "txtBoxFunctionLimit";
            txtBoxFunctionLimit.Size = new Size(114, 30);
            txtBoxFunctionLimit.TabIndex = 33;
            txtBoxFunctionLimit.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label1.Location = new Point(11, 412);
            label1.Name = "label1";
            label1.Size = new Size(270, 23);
            label1.TabIndex = 32;
            label1.Text = "функции (положительная сторона)";
            // 
            // lblLimitation
            // 
            lblLimitation.AutoSize = true;
            lblLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblLimitation.Location = new Point(11, 260);
            lblLimitation.Name = "lblLimitation";
            lblLimitation.Size = new Size(30, 23);
            lblLimitation.TabIndex = 31;
            lblLimitation.Text = "e =";
            // 
            // lblEpsilon
            // 
            lblEpsilon.AutoSize = true;
            lblEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblEpsilon.Location = new Point(11, 199);
            lblEpsilon.Name = "lblEpsilon";
            lblEpsilon.Size = new Size(29, 23);
            lblEpsilon.TabIndex = 30;
            lblEpsilon.Text = "ε =";
            // 
            // txtBoxInterval
            // 
            txtBoxInterval.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxInterval.Location = new Point(12, 374);
            txtBoxInterval.Margin = new Padding(3, 4, 3, 4);
            txtBoxInterval.Name = "txtBoxInterval";
            txtBoxInterval.Size = new Size(114, 30);
            txtBoxInterval.TabIndex = 28;
            txtBoxInterval.Text = "0";
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBox.Location = new Point(12, 440);
            txtBox.Margin = new Padding(3, 4, 3, 4);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(114, 30);
            txtBox.TabIndex = 27;
            txtBox.Text = "0";
            // 
            // txtBoxLimitation
            // 
            txtBoxLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxLimitation.Location = new Point(45, 256);
            txtBoxLimitation.Margin = new Padding(3, 4, 3, 4);
            txtBoxLimitation.Name = "txtBoxLimitation";
            txtBoxLimitation.Size = new Size(114, 30);
            txtBoxLimitation.TabIndex = 26;
            txtBoxLimitation.Text = "0";
            // 
            // txtBoxEpsilon
            // 
            txtBoxEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxEpsilon.Location = new Point(44, 195);
            txtBoxEpsilon.Margin = new Padding(3, 4, 3, 4);
            txtBoxEpsilon.Name = "txtBoxEpsilon";
            txtBoxEpsilon.Size = new Size(114, 30);
            txtBoxEpsilon.TabIndex = 25;
            txtBoxEpsilon.Text = "0,1";
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblText1.Location = new Point(11, 119);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(198, 23);
            lblText1.TabIndex = 24;
            lblText1.Text = "Начальное приближение";
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblFunction.Location = new Point(11, 75);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(45, 23);
            lblFunction.TabIndex = 23;
            lblFunction.Text = "f(x) =";
            // 
            // txtBoxSecondIntervalLim
            // 
            txtBoxSecondIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxSecondIntervalLim.Location = new Point(253, 146);
            txtBoxSecondIntervalLim.Margin = new Padding(3, 4, 3, 4);
            txtBoxSecondIntervalLim.Name = "txtBoxSecondIntervalLim";
            txtBoxSecondIntervalLim.Size = new Size(114, 30);
            txtBoxSecondIntervalLim.TabIndex = 22;
            txtBoxSecondIntervalLim.Text = "0";
            // 
            // txtBoxFirstIntervalLim
            // 
            txtBoxFirstIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFirstIntervalLim.Location = new Point(45, 146);
            txtBoxFirstIntervalLim.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstIntervalLim.Name = "txtBoxFirstIntervalLim";
            txtBoxFirstIntervalLim.Size = new Size(99, 30);
            txtBoxFirstIntervalLim.TabIndex = 21;
            txtBoxFirstIntervalLim.Text = "0";
            // 
            // txtBoxFunction
            // 
            txtBoxFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunction.Location = new Point(59, 71);
            txtBoxFunction.Margin = new Padding(3, 4, 3, 4);
            txtBoxFunction.Name = "txtBoxFunction";
            txtBoxFunction.Size = new Size(308, 30);
            txtBoxFunction.TabIndex = 20;
            txtBoxFunction.Text = "x + 7";
            // 
            // pvGraph
            // 
            pvGraph.Location = new Point(439, 7);
            pvGraph.Margin = new Padding(3, 4, 3, 4);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = Cursors.Hand;
            pvGraph.Size = new Size(457, 533);
            pvGraph.TabIndex = 19;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(919, 36);
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(114, 30);
            toolStripTextBox1.Text = "Построить";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(114, 30);
            toolStripTextBox2.Text = "Вычислить";
            toolStripTextBox2.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label7.Location = new Point(246, 193);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 43;
            label7.Text = "Число итераций";
            // 
            // txtBoxIteration
            // 
            txtBoxIteration.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxIteration.Location = new Point(253, 220);
            txtBoxIteration.Margin = new Padding(3, 4, 3, 4);
            txtBoxIteration.Name = "txtBoxIteration";
            txtBoxIteration.Size = new Size(114, 30);
            txtBoxIteration.TabIndex = 42;
            txtBoxIteration.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn3);
            groupBox1.Controls.Add(rbtn2);
            groupBox1.Location = new Point(262, 293);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(120, 91);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rbtn3.Location = new Point(6, 53);
            rbtn3.Margin = new Padding(3, 4, 3, 4);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(107, 27);
            rbtn3.TabIndex = 2;
            rbtn3.TabStop = true;
            rbtn3.Text = "Максимум";
            rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rbtn2.Location = new Point(6, 18);
            rbtn2.Margin = new Padding(3, 4, 3, 4);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new Size(99, 27);
            rbtn2.TabIndex = 1;
            rbtn2.TabStop = true;
            rbtn2.Text = "Минимум";
            rbtn2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label5.Location = new Point(246, 119);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 45;
            label5.Text = "Значение шага";
            // 
            // coordinateDescentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 558);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(txtBoxIteration);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxFunctionLimit);
            Controls.Add(label1);
            Controls.Add(lblLimitation);
            Controls.Add(lblEpsilon);
            Controls.Add(txtBoxInterval);
            Controls.Add(txtBox);
            Controls.Add(txtBoxLimitation);
            Controls.Add(txtBoxEpsilon);
            Controls.Add(lblText1);
            Controls.Add(lblFunction);
            Controls.Add(txtBoxSecondIntervalLim);
            Controls.Add(txtBoxFirstIntervalLim);
            Controls.Add(txtBoxFunction);
            Controls.Add(pvGraph);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "coordinateDescentForm";
            Text = "Координатный спуск";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBoxFunctionLimit;
        private Label label1;
        private Label lblLimitation;
        private Label lblEpsilon;
        private TextBox txtBoxInterval;
        private TextBox txtBox;
        private TextBox txtBoxLimitation;
        private TextBox txtBoxEpsilon;
        private Label lblText1;
        private Label lblFunction;
        private TextBox txtBoxSecondIntervalLim;
        private TextBox txtBoxFirstIntervalLim;
        private TextBox txtBoxFunction;
        private OxyPlot.WindowsForms.PlotView pvGraph;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private Label label7;
        private TextBox txtBoxIteration;
        private GroupBox groupBox1;
        private RadioButton rbtn3;
        private RadioButton rbtn2;
        private Label label5;
    }
}