namespace MathGameTheCSharpAcademy
{
    partial class ActualGame
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
            panel1 = new Panel();
            labelScore = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            labelOperation = new Label();
            label1 = new Label();
            button1 = new Button();
            labelResultMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 61, 88);
            panel1.Controls.Add(labelResultMessage);
            panel1.Controls.Add(labelScore);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelOperation);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 528);
            panel1.TabIndex = 0;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 15F);
            labelScore.ForeColor = Color.FromArgb(224, 224, 224);
            labelScore.Location = new Point(978, 25);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(65, 28);
            labelScore.TabIndex = 3;
            labelScore.Text = "Score:";
            // 
            // button2
            // 
            button2.Location = new Point(531, 250);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 2;
            button2.Text = "Send answer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(516, 137);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Your answer";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 1;
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.Font = new Font("Segoe UI", 25F);
            labelOperation.ForeColor = Color.White;
            labelOperation.Location = new Point(506, 40);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(172, 46);
            labelOperation.TabIndex = 0;
            labelOperation.Text = "Operation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(413, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 37);
            label1.TabIndex = 1;
            label1.Text = "The Math Game - difficulty: ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(1123, 5);
            button1.Name = "button1";
            button1.Size = new Size(32, 45);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelResultMessage
            // 
            labelResultMessage.AutoSize = true;
            labelResultMessage.Font = new Font("Segoe UI", 12F);
            labelResultMessage.ForeColor = Color.White;
            labelResultMessage.Location = new Point(516, 108);
            labelResultMessage.Name = "labelResultMessage";
            labelResultMessage.Size = new Size(0, 21);
            labelResultMessage.TabIndex = 4;
            // 
            // ActualGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 146, 197);
            ClientSize = new Size(1167, 584);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActualGame";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label labelOperation;
        private Label labelScore;
        private Button button2;
        private TextBox textBox1;
        private Label labelResultMessage;
    }
}