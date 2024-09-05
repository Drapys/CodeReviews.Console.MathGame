namespace MathGameTheCSharpAcademy
{
    partial class DifficultySelector
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(126, 129, 126);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 73);
            button1.Name = "button1";
            button1.Size = new Size(220, 43);
            button1.TabIndex = 0;
            button1.Text = "Easy";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 1;
            label1.Text = "Choose difficulty";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(126, 129, 126);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 122);
            button2.Name = "button2";
            button2.Size = new Size(220, 43);
            button2.TabIndex = 2;
            button2.Text = "Normal";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(126, 129, 126);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 171);
            button3.Name = "button3";
            button3.Size = new Size(220, 43);
            button3.TabIndex = 3;
            button3.Text = "Hard";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(126, 129, 126);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 220);
            button4.Name = "button4";
            button4.Size = new Size(220, 43);
            button4.TabIndex = 4;
            button4.Text = "Random";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // DifficultySelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 61, 88);
            ClientSize = new Size(521, 344);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DifficultySelector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DifficultySelector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}