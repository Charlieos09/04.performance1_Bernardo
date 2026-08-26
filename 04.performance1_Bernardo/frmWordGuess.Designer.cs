namespace _04.performance1_Bernardo
{
    partial class frmWordGuess
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
            backgroundBox = new TextBox();
            Title = new Label();
            Wordle = new Label();
            wrongGroup = new GroupBox();
            lbWrongGuesses = new ListBox();
            wrongTitle = new Label();
            guessBox = new TextBox();
            Confirm = new Button();
            wrongGroup.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundBox
            // 
            backgroundBox.BackColor = Color.DarkSeaGreen;
            backgroundBox.Font = new Font("Segoe UI", 64F);
            backgroundBox.Location = new Point(74, 94);
            backgroundBox.Name = "backgroundBox";
            backgroundBox.Size = new Size(323, 121);
            backgroundBox.TabIndex = 0;
            backgroundBox.TextChanged += textBox1_TextChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Khaki;
            Title.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(116, 44);
            Title.Name = "Title";
            Title.Size = new Size(249, 37);
            Title.TabIndex = 1;
            Title.Text = "Guess the Word";
            Title.Click += label1_Click;
            // 
            // Wordle
            // 
            Wordle.AutoSize = true;
            Wordle.BackColor = Color.DarkSeaGreen;
            Wordle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Wordle.Location = new Point(172, 140);
            Wordle.Name = "Wordle";
            Wordle.Size = new Size(125, 37);
            Wordle.TabIndex = 2;
            Wordle.Text = "Wordle";
            Wordle.Click += Wordle_Click;
            // 
            // wrongGroup
            // 
            wrongGroup.BackColor = SystemColors.InactiveBorder;
            wrongGroup.Controls.Add(lbWrongGuesses);
            wrongGroup.Location = new Point(598, 140);
            wrongGroup.Name = "wrongGroup";
            wrongGroup.Size = new Size(230, 154);
            wrongGroup.TabIndex = 3;
            wrongGroup.TabStop = false;
            // 
            // lbWrongGuesses
            // 
            lbWrongGuesses.FormattingEnabled = true;
            lbWrongGuesses.ItemHeight = 15;
            lbWrongGuesses.Location = new Point(6, 12);
            lbWrongGuesses.Name = "lbWrongGuesses";
            lbWrongGuesses.Size = new Size(218, 124);
            lbWrongGuesses.TabIndex = 0;
            // 
            // wrongTitle
            // 
            wrongTitle.AutoSize = true;
            wrongTitle.BackColor = Color.Khaki;
            wrongTitle.Font = new Font("Microsoft Sans Serif", 20F);
            wrongTitle.ForeColor = Color.Black;
            wrongTitle.Location = new Point(582, 94);
            wrongTitle.Name = "wrongTitle";
            wrongTitle.Size = new Size(262, 31);
            wrongTitle.TabIndex = 4;
            wrongTitle.Text = "Wrong Answers only";
            wrongTitle.Click += Title2_Click;
            // 
            // guessBox
            // 
            guessBox.Font = new Font("Segoe UI", 14F);
            guessBox.Location = new Point(116, 262);
            guessBox.Name = "guessBox";
            guessBox.Size = new Size(236, 32);
            guessBox.TabIndex = 5;
            // 
            // Confirm
            // 
            Confirm.BackColor = Color.Chartreuse;
            Confirm.FlatStyle = FlatStyle.Flat;
            Confirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Confirm.ForeColor = SystemColors.ActiveCaptionText;
            Confirm.Location = new Point(172, 317);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(129, 46);
            Confirm.TabIndex = 6;
            Confirm.Text = "Guess?";
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += Confirm_Click;
            // 
            // frmWordGuess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(919, 450);
            Controls.Add(Title);
            Controls.Add(Confirm);
            Controls.Add(guessBox);
            Controls.Add(wrongTitle);
            Controls.Add(wrongGroup);
            Controls.Add(Wordle);
            Controls.Add(backgroundBox);
            Name = "frmWordGuess";
            Text = "WordGuessr";
            wrongGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        public override bool Equals(object obj)
        {
            return obj is frmWordGuess guess &&
                   EqualityComparer<Label>.Default.Equals(Wordle, guess.Wordle);
        }

        #endregion

        private TextBox backgroundBox;

        public frmWordGuess(TextBox backgroundBox)
        {
            this.backgroundBox = backgroundBox;
        }

        private Label Title;

        public frmWordGuess(Label title)
        {
            Title = title;
        }

        private Label Wordle;
        private GroupBox wrongGroup;
        private ListBox lbWrongGuesses;
        private Label wrongTitle;
        private TextBox guessBox;

        private Button Confirm;
    }
}
