namespace MathGameTheCSharpAcademy
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Static variable that holds the number of points from a highest scoring player
        /// </summary>
        public static int HighScore { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Exit button closes the application
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Opens form with gamemodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;
            DifficultySelector ds = new(this);
            ds.Show();
            
        }
    }
}
