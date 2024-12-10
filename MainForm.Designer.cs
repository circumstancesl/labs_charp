namespace dichotomy_method
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDichotomy = new Button();
            btnGoldenRatio = new Button();
            btnNewton = new Button();
            btnCoordinateDescent = new Button();
            btnSortings = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // btnDichotomy
            // 
            btnDichotomy.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDichotomy.Location = new Point(14, 16);
            btnDichotomy.Margin = new Padding(3, 4, 3, 4);
            btnDichotomy.Name = "btnDichotomy";
            btnDichotomy.Size = new Size(114, 67);
            btnDichotomy.TabIndex = 0;
            btnDichotomy.Text = "Дихотомия";
            btnDichotomy.UseVisualStyleBackColor = true;
            btnDichotomy.Click += btnDichotomy_Click;
            // 
            // btnGoldenRatio
            // 
            btnGoldenRatio.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoldenRatio.Location = new Point(168, 16);
            btnGoldenRatio.Margin = new Padding(3, 4, 3, 4);
            btnGoldenRatio.Name = "btnGoldenRatio";
            btnGoldenRatio.Size = new Size(114, 67);
            btnGoldenRatio.TabIndex = 1;
            btnGoldenRatio.Text = "Золотое сечение";
            btnGoldenRatio.UseVisualStyleBackColor = true;
            btnGoldenRatio.Click += btnGoldenRatio_Click;
            // 
            // btnNewton
            // 
            btnNewton.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewton.Location = new Point(14, 91);
            btnNewton.Margin = new Padding(3, 4, 3, 4);
            btnNewton.Name = "btnNewton";
            btnNewton.Size = new Size(114, 67);
            btnNewton.TabIndex = 2;
            btnNewton.Text = "Метод Ньютона";
            btnNewton.UseVisualStyleBackColor = true;
            btnNewton.Click += btnNewton_Click;
            // 
            // btnCoordinateDescent
            // 
            btnCoordinateDescent.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCoordinateDescent.Location = new Point(168, 91);
            btnCoordinateDescent.Margin = new Padding(3, 4, 3, 4);
            btnCoordinateDescent.Name = "btnCoordinateDescent";
            btnCoordinateDescent.Size = new Size(114, 67);
            btnCoordinateDescent.TabIndex = 3;
            btnCoordinateDescent.Text = "Координатный спуск";
            btnCoordinateDescent.UseVisualStyleBackColor = true;
            btnCoordinateDescent.Click += btnCoordinateDescent_Click_1;
            // 
            // btnSortings
            // 
            btnSortings.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSortings.Location = new Point(14, 165);
            btnSortings.Margin = new Padding(3, 4, 3, 4);
            btnSortings.Name = "btnSortings";
            btnSortings.Size = new Size(114, 67);
            btnSortings.TabIndex = 4;
            btnSortings.Text = "Сортировки";
            btnSortings.UseVisualStyleBackColor = true;
            btnSortings.Click += btnSortings_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(168, 165);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(114, 67);
            button5.TabIndex = 5;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(14, 240);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(114, 67);
            button6.TabIndex = 6;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(168, 240);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(114, 67);
            button7.TabIndex = 7;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 335);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnSortings);
            Controls.Add(btnCoordinateDescent);
            Controls.Add(btnNewton);
            Controls.Add(btnGoldenRatio);
            Controls.Add(btnDichotomy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Приложение";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDichotomy;
        private Button btnGoldenRatio;
        private Button btnNewton;
        private Button btnCoordinateDescent;
        private Button btnSortings;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
