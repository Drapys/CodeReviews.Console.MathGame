namespace MathGameTheCSharpAcademy
{
    partial class Form1
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
            MainPanel = new Panel();
            labelHighscore = new Label();
            label2 = new Label();
            buttonNewGame = new Button();
            label1 = new Label();
            button1 = new Button();
            listboxHistory = new ListBox();
            label3 = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(60, 61, 88);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(listboxHistory);
            MainPanel.Controls.Add(labelHighscore);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(buttonNewGame);
            MainPanel.Location = new Point(0, 50);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1173, 641);
            MainPanel.TabIndex = 0;
            // 
            // labelHighscore
            // 
            labelHighscore.AutoSize = true;
            labelHighscore.Font = new Font("Segoe UI", 15F);
            labelHighscore.ForeColor = Color.White;
            labelHighscore.Location = new Point(985, 12);
            labelHighscore.Name = "labelHighscore";
            labelHighscore.Size = new Size(23, 28);
            labelHighscore.TabIndex = 2;
            labelHighscore.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(875, 12);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Highscore:";
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = Color.FromArgb(126, 129, 126);
            buttonNewGame.FlatAppearance.BorderSize = 0;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonNewGame.ForeColor = Color.White;
            buttonNewGame.Location = new Point(23, 137);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(206, 46);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "NEW GAME";
            buttonNewGame.TextAlign = ContentAlignment.MiddleLeft;
            buttonNewGame.UseVisualStyleBackColor = false;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(445, 1);
            label1.Name = "label1";
            label1.Size = new Size(259, 45);
            label1.TabIndex = 1;
            label1.Text = "The Math Game";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(1128, 1);
            button1.Name = "button1";
            button1.Size = new Size(32, 45);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listboxHistory
            // 
            listboxHistory.BackColor = Color.FromArgb(60, 61, 78);
            listboxHistory.BorderStyle = BorderStyle.None;
            listboxHistory.ForeColor = Color.White;
            listboxHistory.FormattingEnabled = true;
            listboxHistory.ItemHeight = 15;
            listboxHistory.Location = new Point(847, 165);
            listboxHistory.Name = "listboxHistory";
            listboxHistory.Size = new Size(313, 345);
            listboxHistory.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(847, 134);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 146, 197);
            ClientSize = new Size(1172, 689);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private Label label1;
        private Button buttonNewGame;
        private Button button1;
        private Label label2;
        public Label labelHighscore;
        private Label label3;
        public ListBox listboxHistory;
    }
}
