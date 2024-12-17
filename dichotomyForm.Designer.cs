namespace dichotomy_method
{
    partial class dichotomyForm
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
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            txtBoxFunction = new TextBox();
            txtBoxFirstIntervalLim = new TextBox();
            txtBoxSecondIntervalLim = new TextBox();
            lblFunction = new Label();
            lblText1 = new Label();
            txtBoxEpsilon = new TextBox();
            txtBoxLimitation = new TextBox();
            txtBox = new TextBox();
            txtBoxInterval = new TextBox();
            lblText2 = new Label();
            lblEpsilon = new Label();
            lblLimitation = new Label();
            label1 = new Label();
            txtBoxFunctionLimit = new TextBox();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pvGraph
            // 
            pvGraph.Location = new Point(443, 16);
            pvGraph.Margin = new Padding(3, 4, 3, 4);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = Cursors.Hand;
            pvGraph.Size = new Size(457, 533);
            pvGraph.TabIndex = 0;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // txtBoxFunction
            // 
            txtBoxFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunction.Location = new Point(63, 80);
            txtBoxFunction.Margin = new Padding(3, 4, 3, 4);
            txtBoxFunction.Name = "txtBoxFunction";
            txtBoxFunction.Size = new Size(308, 30);
            txtBoxFunction.TabIndex = 1;
            txtBoxFunction.Text = "x + 7";
            // 
            // txtBoxFirstIntervalLim
            // 
            txtBoxFirstIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFirstIntervalLim.Location = new Point(106, 139);
            txtBoxFirstIntervalLim.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstIntervalLim.Name = "txtBoxFirstIntervalLim";
            txtBoxFirstIntervalLim.Size = new Size(114, 30);
            txtBoxFirstIntervalLim.TabIndex = 2;
            txtBoxFirstIntervalLim.Text = "0";
            // 
            // txtBoxSecondIntervalLim
            // 
            txtBoxSecondIntervalLim.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxSecondIntervalLim.Location = new Point(257, 139);
            txtBoxSecondIntervalLim.Margin = new Padding(3, 4, 3, 4);
            txtBoxSecondIntervalLim.Name = "txtBoxSecondIntervalLim";
            txtBoxSecondIntervalLim.Size = new Size(114, 30);
            txtBoxSecondIntervalLim.TabIndex = 3;
            txtBoxSecondIntervalLim.Text = "0";
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblFunction.Location = new Point(15, 84);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(45, 23);
            lblFunction.TabIndex = 4;
            lblFunction.Text = "f(x) =";
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblText1.Location = new Point(14, 143);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(101, 23);
            lblText1.TabIndex = 5;
            lblText1.Text = "Интервал от";
            // 
            // txtBoxEpsilon
            // 
            txtBoxEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxEpsilon.Location = new Point(48, 195);
            txtBoxEpsilon.Margin = new Padding(3, 4, 3, 4);
            txtBoxEpsilon.Name = "txtBoxEpsilon";
            txtBoxEpsilon.Size = new Size(114, 30);
            txtBoxEpsilon.TabIndex = 6;
            txtBoxEpsilon.Text = "0,1";
            // 
            // txtBoxLimitation
            // 
            txtBoxLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxLimitation.Location = new Point(49, 256);
            txtBoxLimitation.Margin = new Padding(3, 4, 3, 4);
            txtBoxLimitation.Name = "txtBoxLimitation";
            txtBoxLimitation.Size = new Size(114, 30);
            txtBoxLimitation.TabIndex = 7;
            txtBoxLimitation.Text = "0";
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBox.Location = new Point(16, 449);
            txtBox.Margin = new Padding(3, 4, 3, 4);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(114, 30);
            txtBox.TabIndex = 8;
            txtBox.Text = "0";
            // 
            // txtBoxInterval
            // 
            txtBoxInterval.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxInterval.Location = new Point(16, 383);
            txtBoxInterval.Margin = new Padding(3, 4, 3, 4);
            txtBoxInterval.Name = "txtBoxInterval";
            txtBoxInterval.Size = new Size(114, 30);
            txtBoxInterval.TabIndex = 9;
            txtBoxInterval.Text = "0";
            // 
            // lblText2
            // 
            lblText2.AutoSize = true;
            lblText2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblText2.Location = new Point(227, 149);
            lblText2.Name = "lblText2";
            lblText2.Size = new Size(29, 23);
            lblText2.TabIndex = 10;
            lblText2.Text = "до";
            // 
            // lblEpsilon
            // 
            lblEpsilon.AutoSize = true;
            lblEpsilon.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblEpsilon.Location = new Point(15, 199);
            lblEpsilon.Name = "lblEpsilon";
            lblEpsilon.Size = new Size(29, 23);
            lblEpsilon.TabIndex = 11;
            lblEpsilon.Text = "ε =";
            // 
            // lblLimitation
            // 
            lblLimitation.AutoSize = true;
            lblLimitation.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            lblLimitation.Location = new Point(15, 260);
            lblLimitation.Name = "lblLimitation";
            lblLimitation.Size = new Size(30, 23);
            lblLimitation.TabIndex = 12;
            lblLimitation.Text = "e =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label1.Location = new Point(15, 421);
            label1.Name = "label1";
            label1.Size = new Size(270, 23);
            label1.TabIndex = 13;
            label1.Text = "функции (положительная сторона)";
            // 
            // txtBoxFunctionLimit
            // 
            txtBoxFunctionLimit.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            txtBoxFunctionLimit.Location = new Point(15, 516);
            txtBoxFunctionLimit.Margin = new Padding(3, 4, 3, 4);
            txtBoxFunctionLimit.Name = "txtBoxFunctionLimit";
            txtBoxFunctionLimit.Size = new Size(114, 30);
            txtBoxFunctionLimit.TabIndex = 14;
            txtBoxFunctionLimit.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label2.Location = new Point(15, 488);
            label2.Name = "label2";
            label2.Size = new Size(266, 23);
            label2.TabIndex = 15;
            label2.Text = "функции (отрицательная сторона)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label3.Location = new Point(16, 355);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 16;
            label3.Text = "осей";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 36);
            menuStrip1.TabIndex = 17;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            label4.Location = new Point(15, 319);
            label4.Name = "label4";
            label4.Size = new Size(236, 23);
            label4.TabIndex = 18;
            label4.Text = "Количество точек построения";
            // 
            // dichotomyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 571);
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
            Controls.Add(pvGraph);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "dichotomyForm";
            Text = "Метод Дихотомии";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView pvGraph;
        private TextBox txtBoxFunction;
        private TextBox txtBoxFirstIntervalLim;
        private TextBox txtBoxSecondIntervalLim;
        private Label lblFunction;
        private Label lblText1;
        private TextBox txtBoxEpsilon;
        private TextBox txtBoxLimitation;
        private TextBox txtBox;
        private TextBox txtBoxInterval;
        private Label lblText2;
        private Label lblEpsilon;
        private Label lblLimitation;
        private Label label1;
        private TextBox txtBoxFunctionLimit;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private Label label4;
    }
}