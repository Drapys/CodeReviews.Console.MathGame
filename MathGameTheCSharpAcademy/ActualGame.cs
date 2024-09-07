using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGameTheCSharpAcademy
{
    public partial class ActualGame : Form
    {
        public int Difficulty { get; set; } = DifficultySelector.difficulty;

        double Answer { get; set; } = 0;

        int score { get; set; } = 0;

        int NumberOfOperation = 0;

        int MaxNumberOfOperations = 0;

        int GoodAnswers = 0;
        int BadAnswers = 0;
        public ActualGame()
        {
            InitializeComponent();
            SetTitle();
            GenerateOperation(Difficulty);



        }

        private void SetTitle()
        {
            string difText = "None";

            switch (Difficulty)
            {
                case 0:
                    difText = "Easy";
                    break;
                case 1:
                    difText = "Normal";
                    break;
                case 2:
                    difText = "Hard";
                    break;
                case 3:
                    difText = "Random";
                    break;
            }

            label1.Text = $"The Math Game - difficulty: {difText}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /// <summary>
        /// Generate an operation in the game based on a difficulty chosen and save the answer to a variable
        /// </summary>
        /// <param name="dif"></param>
        void GenerateOperation(int dif)
        {
            Random random = new Random();

            //Numbers used as minimum and maximum in random generatin
            int randomNum1 = 0;
            int randomNum2 = 0;

            //Decide the range for number generation by difficulty chosen in previous form
            switch (dif)
            {
                case 0:
                    randomNum1 = 0;
                    randomNum2 = 11;
                    MaxNumberOfOperations = 2;
                    break;
                case 1:
                    randomNum1 = 0;
                    randomNum2 = 51;
                    MaxNumberOfOperations = 50;
                    break;
                case 2:
                    randomNum1 = 0;
                    randomNum2 = 101;
                    MaxNumberOfOperations = 100;
                    break;
                case 3:
                    randomNum1 = 0;
                    randomNum2 = random.Next(10, 101);
                    break;
            }


            // Generate two random numbers between 0 and 10
            int num1 = random.Next(0, 11);
            int num2 = random.Next(0, 11);

            // Generate a random operator (0 for +, 1 for -, 2 for *, 3 for /)
            int operation = random.Next(0, 4);

            string operatorSymbol = "";
            double result = 0;



            if(operation == 3)
            {
                // Generate a random dividend from 0 to 100 and a divisor between 1 and 10
                int dividend = random.Next(0, 101);
                int divisor;

                // Ensure divisor is not zero and results in an integer division
                do
                {
                    divisor = random.Next(1, 11); // Divisor between 1 and 10
                } while (dividend % divisor != 0); // Ensure integer result

                num1 = dividend;
                num2 = divisor;
                operatorSymbol = "/";
                result = num1 / num2;
            }
            else
            {

                switch (operation)
                {
                    case 0:
                        operatorSymbol = "+";
                        result = num1 + num2;
                        break;
                    case 1:
                        operatorSymbol = "-";
                        result = num1 - num2;
                        break;
                    case 2:
                        operatorSymbol = "*";
                        result = num1 * num2;
                        break;
                    case 3:
                        operatorSymbol = "/";
                        // Avoid division by zero
                        if (num2 == 0)
                        {
                            operatorSymbol = "+";
                            result = num1 + num2; // Fallback to addition if division by zero
                        }
                        else
                        {
                            result = (double)num1 / num2;
                        }
                        break;
                }
            }

            // Display the generated operation
            labelOperation.Text = ($"{num1} {operatorSymbol} {num2}");

            //Save answer to variable
            Answer = result;
        }


        /// <summary>
        /// Validates the answer and continues based on the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            double answer = 0;

            try
            {
                double.TryParse(textBox1.Text, out answer);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show($"Your answer was in false format, please enter a valid number. Exception message: {formatException.Message}");
            }
            //Compares the answers and gives a result
            if (answer == Answer)
            {
                score++;
                labelScore.Text = $"score: {score}";
                labelResultMessage.Text = "Your last answer was correct! Continue with the next one";
                GoodAnswers++;
            }
            else
            {
                score--;
                labelScore.Text = $"score: {score}";
                labelResultMessage.Text = "Your last answer was wrong :(. Continue with the next one!";
                BadAnswers++;
            }
            NumberOfOperation++;

            CheckNumberOfOperations(NumberOfOperation);
        }

        //Compares the number of current operation to a max number of operation based on difficulty
        void CheckNumberOfOperations(int max)
        {
            if (max == MaxNumberOfOperations)
            {
                MessageBox.Show($"Good job! You have finished the challenge, your score was: {score}");
                Form1 newform = new Form1();
                newform.Show();
                newform.labelHighscore.Text = CheckHighScore().ToString();
                SaveGameToHistory(newform.listboxHistory);
                this.Close();


            }
            else
            {
                GenerateOperation(Difficulty);
            }
        }

        //Saves finished game to a history in main form
        void SaveGameToHistory(ListBox l)
        {
            string GameScoreHistory = $"Score: {score} Questions: {GoodAnswers}/{GoodAnswers+BadAnswers}";
            l.Items.Add(GameScoreHistory);
            
        }


        /// <summary>
        /// Compares the numbers of highscore with the current score and sets new highscore if it was beaten
        /// </summary>
        int CheckHighScore()
        {
            if (score > Form1.HighScore)
            {
                Form1.HighScore = score;

            }
            else
            {
                score = Form1.HighScore;
            }
            return score;
        }
    }
}
