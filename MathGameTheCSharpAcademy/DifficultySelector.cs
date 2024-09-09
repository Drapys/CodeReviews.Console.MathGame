using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGameTheCSharpAcademy
{
    public partial class DifficultySelector : Form
    {
        public static int difficulty {get;set;}


        public Form1? fss = null;
        public DifficultySelector(Form1 fs)
        {
            fss = fs;
            InitializeComponent();
        }
        public enum Difficulty
        {
            Easy,
            Normal,
            Hard,
            Random
        }
        /// <summary>
        /// Method that opens a form with the actual math game and turns the "DifficultySelector" form visible = false
        /// </summary>
        /// <param name="dif"></param>
        void StartGame(int dif)
        {
        


            ActualGame ag = new(fss);
            difficulty = ((int)dif);
            ag.Show();
            this.Close();
        }


        /// <summary>
        /// Easy difficulty button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            StartGame((int)Difficulty.Easy);
        }


        /// <summary>
        /// Normal difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            StartGame((int)Difficulty.Normal);
        }


        /// <summary>
        /// Hard difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            StartGame((int)Difficulty.Hard);
        }


        /// <summary>
        /// Random difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            StartGame((int)Difficulty.Random);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newform = new();
            newform.Show();
            this.Close();
        }
    }
}
