﻿namespace dichotomy_method
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // btnDichotomy
            // 
            btnDichotomy.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDichotomy.Location = new Point(12, 12);
            btnDichotomy.Name = "btnDichotomy";
            btnDichotomy.Size = new Size(100, 50);
            btnDichotomy.TabIndex = 0;
            btnDichotomy.Text = "Дихотомия";
            btnDichotomy.UseVisualStyleBackColor = true;
            btnDichotomy.Click += btnDichotomy_Click;
            // 
            // btnGoldenRatio
            // 
            btnGoldenRatio.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoldenRatio.Location = new Point(147, 12);
            btnGoldenRatio.Name = "btnGoldenRatio";
            btnGoldenRatio.Size = new Size(100, 50);
            btnGoldenRatio.TabIndex = 1;
            btnGoldenRatio.Text = "Золотое сечение";
            btnGoldenRatio.UseVisualStyleBackColor = true;
            btnGoldenRatio.Click += btnGoldenRatio_Click;
            // 
            // btnNewton
            // 
            btnNewton.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewton.Location = new Point(12, 68);
            btnNewton.Name = "btnNewton";
            btnNewton.Size = new Size(100, 50);
            btnNewton.TabIndex = 2;
            btnNewton.Text = "?";
            btnNewton.UseVisualStyleBackColor = true;
            btnNewton.Click += btnNewton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(147, 68);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 3;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 124);
            button4.Name = "button4";
            button4.Size = new Size(100, 50);
            button4.TabIndex = 4;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(147, 124);
            button5.Name = "button5";
            button5.Size = new Size(100, 50);
            button5.TabIndex = 5;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 180);
            button6.Name = "button6";
            button6.Size = new Size(100, 50);
            button6.TabIndex = 6;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(147, 180);
            button7.Name = "button7";
            button7.Size = new Size(100, 50);
            button7.TabIndex = 7;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 251);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnNewton);
            Controls.Add(btnGoldenRatio);
            Controls.Add(btnDichotomy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Приложение";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDichotomy;
        private Button btnGoldenRatio;
        private Button btnNewton;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
