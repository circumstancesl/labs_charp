namespace dichotomy_method
{
    partial class mnkForm
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
            openFileDialog1 = new OpenFileDialog();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            graphPoints = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtBoxOcr = new TextBox();
            label4 = new Label();
            maxNumber = new TextBox();
            minNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            rbtnGenerate = new RadioButton();
            txtBoxMatrix = new TextBox();
            label3 = new Label();
            rbtnFile = new RadioButton();
            rbtnManual = new RadioButton();
            linear = new RadioButton();
            radioButton1 = new RadioButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1161, 36);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(114, 30);
            toolStripTextBox1.Text = "Ввод";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new Size(114, 30);
            toolStripTextBox2.Text = "Высчитать";
            toolStripTextBox2.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // plotView1
            // 
            plotView1.Location = new Point(367, 76);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(758, 558);
            plotView1.TabIndex = 23;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(309, 239);
            dataGridView1.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(graphPoints);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtBoxOcr);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(maxNumber);
            groupBox2.Controls.Add(minNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(rbtnGenerate);
            groupBox2.Controls.Add(txtBoxMatrix);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(rbtnFile);
            groupBox2.Controls.Add(rbtnManual);
            groupBox2.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            groupBox2.Location = new Point(12, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 298);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Настройка ввода";
            // 
            // graphPoints
            // 
            graphPoints.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            graphPoints.Location = new Point(189, 166);
            graphPoints.Name = "graphPoints";
            graphPoints.Size = new Size(56, 26);
            graphPoints.TabIndex = 31;
            graphPoints.Text = "100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 165);
            label6.Name = "label6";
            label6.Size = new Size(177, 21);
            label6.TabIndex = 32;
            label6.Text = "(оси) количество точек -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 205);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 30;
            label5.Text = "точность -";
            // 
            // txtBoxOcr
            // 
            txtBoxOcr.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxOcr.Location = new Point(92, 204);
            txtBoxOcr.Name = "txtBoxOcr";
            txtBoxOcr.Size = new Size(56, 26);
            txtBoxOcr.TabIndex = 29;
            txtBoxOcr.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 236);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 28;
            label4.Text = "числа:";
            // 
            // maxNumber
            // 
            maxNumber.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxNumber.Location = new Point(128, 261);
            maxNumber.Name = "maxNumber";
            maxNumber.Size = new Size(56, 26);
            maxNumber.TabIndex = 27;
            maxNumber.Text = "100";
            // 
            // minNumber
            // 
            minNumber.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minNumber.Location = new Point(33, 261);
            minNumber.Name = "minNumber";
            minNumber.Size = new Size(56, 26);
            minNumber.TabIndex = 26;
            minNumber.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 262);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 25;
            label2.Text = "от";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(95, 262);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 24;
            label1.Text = "до";
            // 
            // rbtnGenerate
            // 
            rbtnGenerate.AutoSize = true;
            rbtnGenerate.Checked = true;
            rbtnGenerate.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnGenerate.Location = new Point(6, 101);
            rbtnGenerate.Name = "rbtnGenerate";
            rbtnGenerate.Size = new Size(113, 28);
            rbtnGenerate.TabIndex = 23;
            rbtnGenerate.TabStop = true;
            rbtnGenerate.Text = "Генерация";
            rbtnGenerate.UseVisualStyleBackColor = true;
            // 
            // txtBoxMatrix
            // 
            txtBoxMatrix.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxMatrix.Location = new Point(152, 134);
            txtBoxMatrix.Name = "txtBoxMatrix";
            txtBoxMatrix.Size = new Size(56, 26);
            txtBoxMatrix.TabIndex = 21;
            txtBoxMatrix.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 21;
            label3.Text = "количество точек -";
            // 
            // rbtnFile
            // 
            rbtnFile.AutoSize = true;
            rbtnFile.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnFile.Location = new Point(6, 67);
            rbtnFile.Name = "rbtnFile";
            rbtnFile.Size = new Size(106, 28);
            rbtnFile.TabIndex = 22;
            rbtnFile.Text = "Из файла";
            rbtnFile.UseVisualStyleBackColor = true;
            // 
            // rbtnManual
            // 
            rbtnManual.AutoSize = true;
            rbtnManual.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnManual.Location = new Point(6, 35);
            rbtnManual.Name = "rbtnManual";
            rbtnManual.Size = new Size(90, 28);
            rbtnManual.TabIndex = 21;
            rbtnManual.Text = "Ручной";
            rbtnManual.UseVisualStyleBackColor = true;
            // 
            // linear
            // 
            linear.AutoSize = true;
            linear.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linear.Location = new Point(12, 343);
            linear.Name = "linear";
            linear.Size = new Size(110, 28);
            linear.TabIndex = 31;
            linear.Text = "Линейная";
            linear.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(142, 343);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(144, 28);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Квадратичная";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // mnkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 663);
            Controls.Add(radioButton1);
            Controls.Add(linear);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(plotView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mnkForm";
            Text = "mnkForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private OpenFileDialog openFileDialog1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtBoxOcr;
        private Label label4;
        private TextBox maxNumber;
        private TextBox minNumber;
        private Label label2;
        private Label label1;
        private RadioButton rbtnGenerate;
        private TextBox txtBoxMatrix;
        private Label label3;
        private RadioButton rbtnFile;
        private RadioButton rbtnManual;
        private RadioButton linear;
        private TextBox graphPoints;
        private Label label6;
        private RadioButton radioButton1;
    }
}