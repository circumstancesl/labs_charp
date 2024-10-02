namespace dichotomy_method
{
    partial class goldenRatioForm
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
            lblText2 = new Label();
            txtBoxInterval = new TextBox();
            txtBox = new TextBox();
            txtBoxLimitation = new TextBox();
            txtBoxEpsilon = new TextBox();
            lblText1 = new Label();
            lblFunction = new Label();
            txtBoxSecondIntervalLim = new TextBox();
            txtBoxFirstIntervalLim = new TextBox();
            txtBoxFunction = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            rBtnMax = new RadioButton();
            rBtnMin = new RadioButton();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label4.Location = new Point(14, 230);
            label4.Name = "label4";
            label4.Size = new Size(186, 18);
            label4.TabIndex = 36;
            label4.Text = "Количество точек построения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label3.Location = new Point(15, 257);
            label3.Name = "label3";
            label3.Size = new Size(36, 18);
            label3.TabIndex = 34;
            label3.Text = "осей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label2.Location = new Point(14, 357);
            label2.Name = "label2";
            label2.Size = new Size(209, 18);
            label2.TabIndex = 33;
            label2.Text = "функции (отрицательная сторона)";
            // 
            // txtBoxFunctionLimit
            // 
            txtBoxFunctionLimit.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunctionLimit.Location = new Point(14, 378);
            txtBoxFunctionLimit.Name = "txtBoxFunctionLimit";
            txtBoxFunctionLimit.Size = new Size(100, 26);
            txtBoxFunctionLimit.TabIndex = 32;
            txtBoxFunctionLimit.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label1.Location = new Point(14, 307);
            label1.Name = "label1";
            label1.Size = new Size(212, 18);
            label1.TabIndex = 31;
            label1.Text = "функции (положительная сторона)";
            // 
            // lblLimitation
            // 
            lblLimitation.AutoSize = true;
            lblLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblLimitation.Location = new Point(14, 186);
            lblLimitation.Name = "lblLimitation";
            lblLimitation.Size = new Size(25, 18);
            lblLimitation.TabIndex = 30;
            lblLimitation.Text = "e =";
            // 
            // lblEpsilon
            // 
            lblEpsilon.AutoSize = true;
            lblEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblEpsilon.Location = new Point(14, 140);
            lblEpsilon.Name = "lblEpsilon";
            lblEpsilon.Size = new Size(24, 18);
            lblEpsilon.TabIndex = 29;
            lblEpsilon.Text = "ε =";
            // 
            // lblText2
            // 
            lblText2.AutoSize = true;
            lblText2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblText2.Location = new Point(200, 103);
            lblText2.Name = "lblText2";
            lblText2.Size = new Size(23, 18);
            lblText2.TabIndex = 28;
            lblText2.Text = "до";
            // 
            // txtBoxInterval
            // 
            txtBoxInterval.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxInterval.Location = new Point(15, 278);
            txtBoxInterval.Name = "txtBoxInterval";
            txtBoxInterval.Size = new Size(100, 26);
            txtBoxInterval.TabIndex = 27;
            txtBoxInterval.Text = "0";
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBox.Location = new Point(15, 328);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 26);
            txtBox.TabIndex = 26;
            txtBox.Text = "0";
            // 
            // txtBoxLimitation
            // 
            txtBoxLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxLimitation.Location = new Point(44, 183);
            txtBoxLimitation.Name = "txtBoxLimitation";
            txtBoxLimitation.Size = new Size(100, 26);
            txtBoxLimitation.TabIndex = 25;
            txtBoxLimitation.Text = "0";
            // 
            // txtBoxEpsilon
            // 
            txtBoxEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxEpsilon.Location = new Point(43, 137);
            txtBoxEpsilon.Name = "txtBoxEpsilon";
            txtBoxEpsilon.Size = new Size(100, 26);
            txtBoxEpsilon.TabIndex = 24;
            txtBoxEpsilon.Text = "0,1";
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblText1.Location = new Point(13, 98);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(79, 18);
            lblText1.TabIndex = 23;
            lblText1.Text = "Интервал от";
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblFunction.Location = new Point(14, 54);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(37, 18);
            lblFunction.TabIndex = 22;
            lblFunction.Text = "f(x) =";
            // 
            // txtBoxSecondIntervalLim
            // 
            txtBoxSecondIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxSecondIntervalLim.Location = new Point(226, 95);
            txtBoxSecondIntervalLim.Name = "txtBoxSecondIntervalLim";
            txtBoxSecondIntervalLim.Size = new Size(100, 26);
            txtBoxSecondIntervalLim.TabIndex = 21;
            txtBoxSecondIntervalLim.Text = "0";
            // 
            // txtBoxFirstIntervalLim
            // 
            txtBoxFirstIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFirstIntervalLim.Location = new Point(94, 95);
            txtBoxFirstIntervalLim.Name = "txtBoxFirstIntervalLim";
            txtBoxFirstIntervalLim.Size = new Size(100, 26);
            txtBoxFirstIntervalLim.TabIndex = 20;
            txtBoxFirstIntervalLim.Text = "0";
            // 
            // txtBoxFunction
            // 
            txtBoxFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunction.Location = new Point(56, 51);
            txtBoxFunction.Name = "txtBoxFunction";
            txtBoxFunction.Size = new Size(270, 26);
            txtBoxFunction.TabIndex = 19;
            txtBoxFunction.Text = "x + 7";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 35;
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
            // pvGraph
            // 
            pvGraph.Location = new Point(344, 33);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = Cursors.Hand;
            pvGraph.Size = new Size(444, 458);
            pvGraph.TabIndex = 37;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // rBtnMax
            // 
            rBtnMax.AutoSize = true;
            rBtnMax.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rBtnMax.Location = new Point(6, 22);
            rBtnMax.Name = "rBtnMax";
            rBtnMax.Size = new Size(86, 22);
            rBtnMax.TabIndex = 38;
            rBtnMax.TabStop = true;
            rBtnMax.Text = "Максимум";
            rBtnMax.UseVisualStyleBackColor = true;
            // 
            // rBtnMin
            // 
            rBtnMin.AutoSize = true;
            rBtnMin.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            rBtnMin.Location = new Point(6, 50);
            rBtnMin.Name = "rBtnMin";
            rBtnMin.Size = new Size(79, 22);
            rBtnMin.TabIndex = 39;
            rBtnMin.TabStop = true;
            rBtnMin.Text = "Минимум";
            rBtnMin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtnMax);
            groupBox1.Controls.Add(rBtnMin);
            groupBox1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            groupBox1.Location = new Point(14, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(102, 81);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ищем";
            // 
            // goldenRatioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(groupBox1);
            Controls.Add(pvGraph);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxFunctionLimit);
            Controls.Add(label1);
            Controls.Add(lblLimitation);
            Controls.Add(lblEpsilon);
            Controls.Add(lblText2);
            Controls.Add(txtBoxInterval);
            Controls.Add(txtBox);
            Controls.Add(txtBoxLimitation);
            Controls.Add(txtBoxEpsilon);
            Controls.Add(lblText1);
            Controls.Add(lblFunction);
            Controls.Add(txtBoxSecondIntervalLim);
            Controls.Add(txtBoxFirstIntervalLim);
            Controls.Add(txtBoxFunction);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "goldenRatioForm";
            Text = "Метод золотого сечения";
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
        private Label lblText2;
        private TextBox txtBoxInterval;
        private TextBox txtBox;
        private TextBox txtBoxLimitation;
        private TextBox txtBoxEpsilon;
        private Label lblText1;
        private Label lblFunction;
        private TextBox txtBoxSecondIntervalLim;
        private TextBox txtBoxFirstIntervalLim;
        private TextBox txtBoxFunction;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private OxyPlot.WindowsForms.PlotView pvGraph;
        private RadioButton rBtnMax;
        private RadioButton rBtnMin;
        private GroupBox groupBox1;
    }
}