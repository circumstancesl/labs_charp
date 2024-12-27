namespace dichotomy_method
{
    partial class matrixForm
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
            openFileDialog1 = new OpenFileDialog();
            groupBox2 = new GroupBox();
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
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            sortGroup = new GroupBox();
            rbtnGauss = new RadioButton();
            rbtnGaussJordan = new RadioButton();
            rbtnCramer = new RadioButton();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            rbtnDouble = new RadioButton();
            rbtnInt = new RadioButton();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            sortGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(12, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 260);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Настройка ввода";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 169);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 30;
            label5.Text = "точность -";
            // 
            // txtBoxOcr
            // 
            txtBoxOcr.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxOcr.Location = new Point(92, 168);
            txtBoxOcr.Name = "txtBoxOcr";
            txtBoxOcr.Size = new Size(56, 26);
            txtBoxOcr.TabIndex = 29;
            txtBoxOcr.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 200);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 28;
            label4.Text = "числа:";
            // 
            // maxNumber
            // 
            maxNumber.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxNumber.Location = new Point(128, 225);
            maxNumber.Name = "maxNumber";
            maxNumber.Size = new Size(56, 26);
            maxNumber.TabIndex = 27;
            maxNumber.Text = "100";
            // 
            // minNumber
            // 
            minNumber.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minNumber.Location = new Point(33, 225);
            minNumber.Name = "minNumber";
            minNumber.Size = new Size(56, 26);
            minNumber.TabIndex = 26;
            minNumber.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 226);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 25;
            label2.Text = "от";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(95, 226);
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
            txtBoxMatrix.Location = new Point(176, 134);
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
            label3.Size = new Size(168, 21);
            label3.TabIndex = 21;
            label3.Text = "размерность матрицы -";
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1205, 36);
            menuStrip1.TabIndex = 21;
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
            // sortGroup
            // 
            sortGroup.Controls.Add(rbtnGauss);
            sortGroup.Controls.Add(rbtnGaussJordan);
            sortGroup.Controls.Add(rbtnCramer);
            sortGroup.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sortGroup.Location = new Point(12, 404);
            sortGroup.Name = "sortGroup";
            sortGroup.Size = new Size(243, 166);
            sortGroup.TabIndex = 22;
            sortGroup.TabStop = false;
            sortGroup.Text = "Методы";
            // 
            // rbtnGauss
            // 
            rbtnGauss.AutoSize = true;
            rbtnGauss.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnGauss.Location = new Point(6, 104);
            rbtnGauss.Name = "rbtnGauss";
            rbtnGauss.Size = new Size(83, 28);
            rbtnGauss.TabIndex = 25;
            rbtnGauss.Text = "Гаусса";
            rbtnGauss.UseVisualStyleBackColor = true;
            // 
            // rbtnGaussJordan
            // 
            rbtnGaussJordan.AutoSize = true;
            rbtnGaussJordan.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnGaussJordan.Location = new Point(6, 70);
            rbtnGaussJordan.Name = "rbtnGaussJordan";
            rbtnGaussJordan.Size = new Size(164, 28);
            rbtnGaussJordan.TabIndex = 24;
            rbtnGaussJordan.Text = "Гаусса-Жордана";
            rbtnGaussJordan.UseVisualStyleBackColor = true;
            // 
            // rbtnCramer
            // 
            rbtnCramer.AutoSize = true;
            rbtnCramer.Checked = true;
            rbtnCramer.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnCramer.Location = new Point(6, 35);
            rbtnCramer.Name = "rbtnCramer";
            rbtnCramer.Size = new Size(98, 28);
            rbtnCramer.TabIndex = 23;
            rbtnCramer.TabStop = true;
            rbtnCramer.Text = "Крамера";
            rbtnCramer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(495, 481);
            dataGridView1.TabIndex = 23;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(824, 54);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 481);
            dataGridView2.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnDouble);
            groupBox1.Controls.Add(rbtnInt);
            groupBox1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 75);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Генерировать";
            // 
            // rbtnDouble
            // 
            rbtnDouble.AutoSize = true;
            rbtnDouble.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnDouble.Location = new Point(136, 35);
            rbtnDouble.Name = "rbtnDouble";
            rbtnDouble.Size = new Size(101, 28);
            rbtnDouble.TabIndex = 24;
            rbtnDouble.Text = "Дробные";
            rbtnDouble.UseVisualStyleBackColor = true;
            // 
            // rbtnInt
            // 
            rbtnInt.AutoSize = true;
            rbtnInt.Checked = true;
            rbtnInt.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnInt.Location = new Point(6, 35);
            rbtnInt.Name = "rbtnInt";
            rbtnInt.Size = new Size(83, 28);
            rbtnInt.TabIndex = 23;
            rbtnInt.TabStop = true;
            rbtnInt.Text = "Целые";
            rbtnInt.UseVisualStyleBackColor = true;
            // 
            // matrixForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 560);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(sortGroup);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox2);
            Name = "matrixForm";
            Text = "matrixForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            sortGroup.ResumeLayout(false);
            sortGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2;
        private TextBox txtBoxMatrix;
        private Label label3;
        private RadioButton rbtnFile;
        private RadioButton rbtnManual;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private GroupBox sortGroup;
        private RadioButton rbtnGauss;
        private RadioButton rbtnGaussJordan;
        private RadioButton rbtnCramer;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private RadioButton rbtnGenerate;
        private Label label4;
        private TextBox maxNumber;
        private TextBox minNumber;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnDouble;
        private RadioButton rbtnInt;
        private Label label5;
        private TextBox txtBoxOcr;
    }
}