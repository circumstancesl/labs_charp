namespace dichotomy_method
{
    partial class NewtonForm
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
            lblFunction = new Label();
            txtBoxSecondIntervalLim = new TextBox();
            txtBoxFirstIntervalLim = new TextBox();
            txtBoxFunction = new TextBox();
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            txtBoxIteration = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            rbtn3 = new RadioButton();
            rbtn2 = new RadioButton();
            rbtn1 = new RadioButton();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label4.Location = new Point(13, 258);
            label4.Name = "label4";
            label4.Size = new Size(186, 18);
            label4.TabIndex = 37;
            label4.Text = "Количество точек построения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label3.Location = new Point(14, 285);
            label3.Name = "label3";
            label3.Size = new Size(36, 18);
            label3.TabIndex = 35;
            label3.Text = "осей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label2.Location = new Point(13, 385);
            label2.Name = "label2";
            label2.Size = new Size(209, 18);
            label2.TabIndex = 34;
            label2.Text = "функции (отрицательная сторона)";
            // 
            // txtBoxFunctionLimit
            // 
            txtBoxFunctionLimit.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunctionLimit.Location = new Point(13, 406);
            txtBoxFunctionLimit.Name = "txtBoxFunctionLimit";
            txtBoxFunctionLimit.Size = new Size(100, 26);
            txtBoxFunctionLimit.TabIndex = 33;
            txtBoxFunctionLimit.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label1.Location = new Point(13, 335);
            label1.Name = "label1";
            label1.Size = new Size(212, 18);
            label1.TabIndex = 32;
            label1.Text = "функции (положительная сторона)";
            // 
            // lblLimitation
            // 
            lblLimitation.AutoSize = true;
            lblLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblLimitation.Location = new Point(13, 214);
            lblLimitation.Name = "lblLimitation";
            lblLimitation.Size = new Size(25, 18);
            lblLimitation.TabIndex = 31;
            lblLimitation.Text = "e =";
            // 
            // lblEpsilon
            // 
            lblEpsilon.AutoSize = true;
            lblEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblEpsilon.Location = new Point(13, 168);
            lblEpsilon.Name = "lblEpsilon";
            lblEpsilon.Size = new Size(24, 18);
            lblEpsilon.TabIndex = 30;
            lblEpsilon.Text = "ε =";
            // 
            // txtBoxInterval
            // 
            txtBoxInterval.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxInterval.Location = new Point(14, 306);
            txtBoxInterval.Name = "txtBoxInterval";
            txtBoxInterval.Size = new Size(100, 26);
            txtBoxInterval.TabIndex = 28;
            txtBoxInterval.Text = "0";
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBox.Location = new Point(14, 356);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 26);
            txtBox.TabIndex = 27;
            txtBox.Text = "0";
            // 
            // txtBoxLimitation
            // 
            txtBoxLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxLimitation.Location = new Point(43, 211);
            txtBoxLimitation.Name = "txtBoxLimitation";
            txtBoxLimitation.Size = new Size(100, 26);
            txtBoxLimitation.TabIndex = 26;
            txtBoxLimitation.Text = "0";
            // 
            // txtBoxEpsilon
            // 
            txtBoxEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxEpsilon.Location = new Point(42, 165);
            txtBoxEpsilon.Name = "txtBoxEpsilon";
            txtBoxEpsilon.Size = new Size(100, 26);
            txtBoxEpsilon.TabIndex = 25;
            txtBoxEpsilon.Text = "0,1";
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblFunction.Location = new Point(13, 49);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(37, 18);
            lblFunction.TabIndex = 23;
            lblFunction.Text = "f(x) =";
            // 
            // txtBoxSecondIntervalLim
            // 
            txtBoxSecondIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxSecondIntervalLim.Location = new Point(225, 111);
            txtBoxSecondIntervalLim.Name = "txtBoxSecondIntervalLim";
            txtBoxSecondIntervalLim.Size = new Size(100, 26);
            txtBoxSecondIntervalLim.TabIndex = 22;
            txtBoxSecondIntervalLim.Text = "0";
            // 
            // txtBoxFirstIntervalLim
            // 
            txtBoxFirstIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFirstIntervalLim.Location = new Point(42, 111);
            txtBoxFirstIntervalLim.Name = "txtBoxFirstIntervalLim";
            txtBoxFirstIntervalLim.Size = new Size(100, 26);
            txtBoxFirstIntervalLim.TabIndex = 21;
            txtBoxFirstIntervalLim.Text = "0";
            // 
            // txtBoxFunction
            // 
            txtBoxFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunction.Location = new Point(55, 46);
            txtBoxFunction.Name = "txtBoxFunction";
            txtBoxFunction.Size = new Size(270, 26);
            txtBoxFunction.TabIndex = 20;
            txtBoxFunction.Text = "x + 7";
            // 
            // pvGraph
            // 
            pvGraph.Location = new Point(388, 31);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = Cursors.Hand;
            pvGraph.Size = new Size(400, 400);
            pvGraph.TabIndex = 19;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 26);
            toolStripTextBox1.Text = "Построить";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 26);
            toolStripTextBox2.Text = "Вычислить";
            toolStripTextBox2.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // txtBoxIteration
            // 
            txtBoxIteration.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxIteration.Location = new Point(225, 211);
            txtBoxIteration.Name = "txtBoxIteration";
            txtBoxIteration.Size = new Size(100, 26);
            txtBoxIteration.TabIndex = 38;
            txtBoxIteration.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label5.Location = new Point(14, 90);
            label5.Name = "label5";
            label5.Size = new Size(155, 18);
            label5.TabIndex = 39;
            label5.Text = "Начальное приближение";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label6.Location = new Point(211, 90);
            label6.Name = "label6";
            label6.Size = new Size(129, 18);
            label6.TabIndex = 40;
            label6.Text = "Зн. для числ. дифф.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label7.Location = new Point(225, 190);
            label7.Name = "label7";
            label7.Size = new Size(102, 18);
            label7.TabIndex = 41;
            label7.Text = "Число итераций";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn3);
            groupBox1.Controls.Add(rbtn2);
            groupBox1.Controls.Add(rbtn1);
            groupBox1.Location = new Point(235, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(105, 100);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rbtn3.Location = new Point(5, 62);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(86, 22);
            rbtn3.TabIndex = 2;
            rbtn3.TabStop = true;
            rbtn3.Text = "Максимум";
            rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rbtn2.Location = new Point(5, 37);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new Size(79, 22);
            rbtn2.TabIndex = 1;
            rbtn2.TabStop = true;
            rbtn2.Text = "Минимум";
            rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rbtn1.Location = new Point(5, 12);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(104, 22);
            rbtn1.TabIndex = 0;
            rbtn1.TabStop = true;
            rbtn1.Text = "Пересечение";
            rbtn1.UseVisualStyleBackColor = true;
            // 
            // NewtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
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
            Controls.Add(lblFunction);
            Controls.Add(txtBoxSecondIntervalLim);
            Controls.Add(txtBoxFirstIntervalLim);
            Controls.Add(txtBoxFunction);
            Controls.Add(pvGraph);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewtonForm";
            Text = "Метод Ньютона";
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
        private Label lblFunction;
        private TextBox txtBoxSecondIntervalLim;
        private TextBox txtBoxFirstIntervalLim;
        private TextBox txtBoxFunction;
        private OxyPlot.WindowsForms.PlotView pvGraph;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private TextBox txtBoxIteration;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton rbtn3;
        private RadioButton rbtn2;
        private RadioButton rbtn1;
    }
}