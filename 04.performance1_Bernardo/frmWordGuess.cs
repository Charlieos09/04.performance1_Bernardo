namespace _04.performance1_Bernardo
{
    public partial class frmWordGuess : Form
    {
        public frmWordGuess()
        {
            InitializeComponent();


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
            string guess = guessBox.Text;
            if (string.IsNullOrEmpty(guess))
            {
                 MessageBox.Show("Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title2_Click(object sender, EventArgs e)
        {

        }
    }
}
