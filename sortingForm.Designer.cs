namespace dichotomy_method
{
    partial class sortingForm
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
            sortGroup = new GroupBox();
            rbtnDecrease = new RadioButton();
            rbtnIncrease = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            maxIterations = new TextBox();
            inserts = new CheckBox();
            shake = new CheckBox();
            bubble = new CheckBox();
            fast = new CheckBox();
            swamp = new CheckBox();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbtnDouble = new RadioButton();
            rbtnInt = new RadioButton();
            txtBoxRightLimit = new TextBox();
            txtBoxLeftLimit = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtBoxCountNumbers = new TextBox();
            label3 = new Label();
            btnPath = new Button();
            rbtnGeneration = new RadioButton();
            rbtnFile = new RadioButton();
            rbtnManual = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            progressBar1 = new ProgressBar();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Method = new DataGridViewTextBoxColumn();
            Iterations = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sortGroup.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // sortGroup
            // 
            sortGroup.Controls.Add(rbtnDecrease);
            sortGroup.Controls.Add(rbtnIncrease);
            sortGroup.Controls.Add(label2);
            sortGroup.Controls.Add(label1);
            sortGroup.Controls.Add(maxIterations);
            sortGroup.Controls.Add(inserts);
            sortGroup.Controls.Add(shake);
            sortGroup.Controls.Add(bubble);
            sortGroup.Controls.Add(fast);
            sortGroup.Controls.Add(swamp);
            sortGroup.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sortGroup.Location = new Point(301, 56);
            sortGroup.Name = "sortGroup";
            sortGroup.Size = new Size(286, 292);
            sortGroup.TabIndex = 0;
            sortGroup.TabStop = false;
            sortGroup.Text = "Сортировки";
            // 
            // rbtnDecrease
            // 
            rbtnDecrease.AutoSize = true;
            rbtnDecrease.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnDecrease.Location = new Point(174, 252);
            rbtnDecrease.Name = "rbtnDecrease";
            rbtnDecrease.Size = new Size(106, 26);
            rbtnDecrease.TabIndex = 20;
            rbtnDecrease.TabStop = true;
            rbtnDecrease.Text = "Убыванию";
            rbtnDecrease.UseVisualStyleBackColor = true;
            // 
            // rbtnIncrease
            // 
            rbtnIncrease.AutoSize = true;
            rbtnIncrease.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnIncrease.Location = new Point(6, 252);
            rbtnIncrease.Name = "rbtnIncrease";
            rbtnIncrease.Size = new Size(125, 26);
            rbtnIncrease.TabIndex = 19;
            rbtnIncrease.TabStop = true;
            rbtnIncrease.Text = "Возрастанию";
            rbtnIncrease.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(75, 212);
            label2.Name = "label2";
            label2.Size = new Size(128, 24);
            label2.TabIndex = 6;
            label2.Text = "Сортировка по:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(141, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "максимум итераций";
            // 
            // maxIterations
            // 
            maxIterations.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxIterations.Location = new Point(165, 43);
            maxIterations.Name = "maxIterations";
            maxIterations.Size = new Size(91, 26);
            maxIterations.TabIndex = 1;
            maxIterations.Text = "1000";
            // 
            // inserts
            // 
            inserts.AutoSize = true;
            inserts.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            inserts.Location = new Point(6, 172);
            inserts.Name = "inserts";
            inserts.Size = new Size(112, 27);
            inserts.TabIndex = 5;
            inserts.Text = "Вставками";
            inserts.UseVisualStyleBackColor = true;
            // 
            // shake
            // 
            shake.AutoSize = true;
            shake.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            shake.Location = new Point(6, 139);
            shake.Name = "shake";
            shake.Size = new Size(118, 27);
            shake.TabIndex = 4;
            shake.Text = "Шейкерная";
            shake.UseVisualStyleBackColor = true;
            // 
            // bubble
            // 
            bubble.AutoSize = true;
            bubble.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            bubble.Location = new Point(6, 74);
            bubble.Name = "bubble";
            bubble.Size = new Size(133, 27);
            bubble.TabIndex = 1;
            bubble.Text = "Пузырьковая";
            bubble.UseVisualStyleBackColor = true;
            // 
            // fast
            // 
            fast.AutoSize = true;
            fast.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            fast.Location = new Point(6, 106);
            fast.Name = "fast";
            fast.Size = new Size(96, 27);
            fast.TabIndex = 3;
            fast.Text = "Быстрая";
            fast.UseVisualStyleBackColor = true;
            // 
            // swamp
            // 
            swamp.AutoSize = true;
            swamp.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            swamp.Location = new Point(6, 41);
            swamp.Name = "swamp";
            swamp.Size = new Size(103, 27);
            swamp.TabIndex = 2;
            swamp.Text = "Болотная";
            swamp.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1063, 36);
            menuStrip1.TabIndex = 18;
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
            toolStripTextBox1.Click += toolStripTextBox1_Click_1;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Font = new Font("Bahnschrift SemiCondensed", 11.25F);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new Size(114, 30);
            toolStripTextBox2.Text = "Сортировать";
            toolStripTextBox2.TextBoxTextAlign = HorizontalAlignment.Center;
            toolStripTextBox2.Click += toolStripTextBox2_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtBoxRightLimit);
            groupBox1.Controls.Add(txtBoxLeftLimit);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBoxCountNumbers);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnPath);
            groupBox1.Controls.Add(rbtnGeneration);
            groupBox1.Controls.Add(rbtnFile);
            groupBox1.Controls.Add(rbtnManual);
            groupBox1.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 292);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройка ввода";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnDouble);
            groupBox2.Controls.Add(rbtnInt);
            groupBox2.Font = new Font("Bahnschrift Light SemiCondensed", 12F);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(0, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 80);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Генерировать:";
            // 
            // rbtnDouble
            // 
            rbtnDouble.AutoSize = true;
            rbtnDouble.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnDouble.Location = new Point(148, 40);
            rbtnDouble.Name = "rbtnDouble";
            rbtnDouble.Size = new Size(96, 26);
            rbtnDouble.TabIndex = 22;
            rbtnDouble.TabStop = true;
            rbtnDouble.Text = "Дробные";
            rbtnDouble.UseVisualStyleBackColor = true;
            // 
            // rbtnInt
            // 
            rbtnInt.AutoSize = true;
            rbtnInt.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnInt.Location = new Point(6, 40);
            rbtnInt.Name = "rbtnInt";
            rbtnInt.Size = new Size(78, 26);
            rbtnInt.TabIndex = 21;
            rbtnInt.TabStop = true;
            rbtnInt.Text = "Целые";
            rbtnInt.UseVisualStyleBackColor = true;
            // 
            // txtBoxRightLimit
            // 
            txtBoxRightLimit.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxRightLimit.Location = new Point(153, 166);
            txtBoxRightLimit.Name = "txtBoxRightLimit";
            txtBoxRightLimit.Size = new Size(91, 26);
            txtBoxRightLimit.TabIndex = 26;
            txtBoxRightLimit.Text = "1000";
            // 
            // txtBoxLeftLimit
            // 
            txtBoxLeftLimit.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxLeftLimit.Location = new Point(32, 166);
            txtBoxLeftLimit.Name = "txtBoxLeftLimit";
            txtBoxLeftLimit.Size = new Size(91, 26);
            txtBoxLeftLimit.TabIndex = 25;
            txtBoxLeftLimit.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(125, 168);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 24;
            label5.Text = "до";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 168);
            label4.Name = "label4";
            label4.Size = new Size(24, 21);
            label4.TabIndex = 23;
            label4.Text = "от";
            // 
            // txtBoxCountNumbers
            // 
            txtBoxCountNumbers.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxCountNumbers.Location = new Point(153, 129);
            txtBoxCountNumbers.Name = "txtBoxCountNumbers";
            txtBoxCountNumbers.Size = new Size(91, 26);
            txtBoxCountNumbers.TabIndex = 21;
            txtBoxCountNumbers.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 21;
            label3.Text = "количество чисел -";
            // 
            // btnPath
            // 
            btnPath.Font = new Font("Bahnschrift Light SemiCondensed", 10.2F);
            btnPath.Location = new Point(138, 67);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(94, 29);
            btnPath.TabIndex = 20;
            btnPath.Text = "выбор пути";
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += btnPath_Click;
            // 
            // rbtnGeneration
            // 
            rbtnGeneration.AutoSize = true;
            rbtnGeneration.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnGeneration.Location = new Point(6, 99);
            rbtnGeneration.Name = "rbtnGeneration";
            rbtnGeneration.Size = new Size(117, 28);
            rbtnGeneration.TabIndex = 22;
            rbtnGeneration.TabStop = true;
            rbtnGeneration.Text = "Генерация:";
            rbtnGeneration.UseVisualStyleBackColor = true;
            // 
            // rbtnFile
            // 
            rbtnFile.AutoSize = true;
            rbtnFile.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbtnFile.Location = new Point(6, 67);
            rbtnFile.Name = "rbtnFile";
            rbtnFile.Size = new Size(106, 28);
            rbtnFile.TabIndex = 22;
            rbtnFile.TabStop = true;
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
            rbtnManual.TabStop = true;
            rbtnManual.Text = "Ручной";
            rbtnManual.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Fuchsia;
            progressBar1.ForeColor = Color.Fuchsia;
            progressBar1.Location = new Point(699, 68);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(313, 29);
            progressBar1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(699, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(313, 502);
            dataGridView1.TabIndex = 21;
            dataGridView1.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Числа для сортировки";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Method, Iterations, Time, Column4 });
            dataGridView2.Location = new Point(12, 365);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(642, 267);
            dataGridView2.TabIndex = 22;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // Method
            // 
            Method.HeaderText = "Метод";
            Method.MinimumWidth = 6;
            Method.Name = "Method";
            Method.Width = 125;
            // 
            // Iterations
            // 
            Iterations.HeaderText = "Итерации";
            Iterations.MinimumWidth = 6;
            Iterations.Name = "Iterations";
            Iterations.Width = 125;
            // 
            // Time
            // 
            Time.HeaderText = "Время";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Открыть файл";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // sortingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 661);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(sortGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "sortingForm";
            Text = "Сортировки";
            sortGroup.ResumeLayout(false);
            sortGroup.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox sortGroup;
        private CheckBox bubble;
        private CheckBox inserts;
        private CheckBox shake;
        private CheckBox fast;
        private CheckBox swamp;
        private TextBox maxIterations;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private Label label2;
        private RadioButton rbtnDecrease;
        private RadioButton rbtnIncrease;
        private GroupBox groupBox1;
        private RadioButton rbtnGeneration;
        private RadioButton rbtnFile;
        private RadioButton rbtnManual;
        private TextBox txtBoxRightLimit;
        private TextBox txtBoxLeftLimit;
        private Label label5;
        private Label label4;
        private TextBox txtBoxCountNumbers;
        private Label label3;
        private Button btnPath;
        private GroupBox groupBox2;
        private RadioButton rbtnDouble;
        private RadioButton rbtnInt;
        private OpenFileDialog openFileDialog1;
        private ProgressBar progressBar1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Method;
        private DataGridViewTextBoxColumn Iterations;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}