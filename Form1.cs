namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// A guessing game.  Written using WinForms in .Net 6.0 and C#
        /// created by Nigel Booth 2022
        /// </summary>
        //Start by creating a random number generator
        Random random = new Random();
        int guesses = 0;
        int guessesLeft = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for initial test only
            //random.Next(0, 9);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            //seed the random number generator and assign a random number to int r
            int r = random.Next(0, 9) + 1;

            //Check that numerical int is entered.
            bool isNumeric = int.TryParse(guessBox.Text, out int n);
            if (isNumeric == false) { MessageBox.Show("please enter a numerical integer value only!"); }

            int guess = int.Parse(guessBox.Text);
            while (guessesLeft > 0)
            {
                guessesLeft--;
                guesses++;
                NumGuessesBx.Text = guesses.ToString();
                NumLeftBx.Text = guessesLeft.ToString();

                //If you pick the correct one then show the picture
                if (guess == r)
                {
                    MessageBox.Show("Well Done!");
                    pictureBox1.Visible = true; break; 
                }
                if(guess != r)
                { MessageBox.Show("incorrect, please try again"); break; }
            }

            if (guessesLeft == 0)
            { 
                //if you lose then we stop.
                pictureBox1.Visible = false;
                MessageBox.Show("Out of guesses! Better luck next time.");
            }
        }
    }
}