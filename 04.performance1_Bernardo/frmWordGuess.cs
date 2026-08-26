namespace _04.performance1_Bernardo
{
    public partial class frmWordGuess : Form
    {
        private string secretWord = string.Empty;
        private readonly string[] wordList = { "CODES", "HACKS", "LOOPS", "MINDS", "IDEAS" };
        private readonly char maskChar = '?';

        public frmWordGuess()
        {
            InitializeComponent();
            ResetGame();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Wordle_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string guess = guessBox.Text.Trim().ToUpperInvariant();
            if (string.IsNullOrEmpty(guess))
            {
                MessageBox.Show("Please enter a 5-letter guess.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (guess.Length != 5)
            {
                MessageBox.Show("Guess must be exactly 5 letters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (guess == secretWord)
            {
                MessageBox.Show($"Correct! The word was {secretWord}.", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
                return;
            }

            if (!lbWrongGuesses.Items.Contains(guess))
            {
                lbWrongGuesses.Items.Add(guess);
            }

            guessBox.Clear();
            guessBox.Focus();
        }

        private void ResetGame()
        {
            
            secretWord = wordList[Random.Shared.Next(wordList.Length)];
            
            lbWrongGuesses.Items.Clear();
            guessBox.Clear();
            UpdateWordleDisplay();
            guessBox.Focus();
        }

        private void UpdateWordleDisplay()
        {
            if (string.IsNullOrEmpty(secretWord))
            {
                Wordle.Text = string.Empty;
                return;
            }

            if (secretWord.Length <= 2)
            {
                Wordle.Text = secretWord; // nothing to mask
                return;
            }

            int middleCount = secretWord.Length - 2;
            Wordle.Text = secretWord[0] + new string(maskChar, middleCount) + secretWord[^1];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title2_Click(object sender, EventArgs e)
        {

        }
    }
}
