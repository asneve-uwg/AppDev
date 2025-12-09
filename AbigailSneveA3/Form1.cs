namespace AbigailSneveA4
{
    /// <summary>
    /// Represents the main form for the application, providing functionality for word validation, word metrics, and
    /// various word-based operations such as generating word squares, pyramids, and palindromes.
    /// </summary>
    /// <remarks>This form serves as the user interface for interacting with word-based operations. It
    /// includes functionality for validating input words, performing operations such as checking for common letters,
    /// generating word metrics, and handling numeric word conversions. The form also provides menu items and buttons
    /// for triggering these operations, with results displayed in the output label.</remarks>
    public sealed partial class Form1 : Form
    {
        private string? _wordOne;
        private string? _wordTwo;
        private bool _bothValid;
        /// <summary>
        /// Gets or sets the first word in the sequence.
        /// </summary>
        public string? WordOne
        {
            get => _wordOne;
            set => _wordOne = value;
        } 
        /// <summary>
        /// /// Gets or sets the second word in the sequence.
        /// </summary>
        public string? WordTwo
        {
            get => _wordTwo;
            set => _wordTwo = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether both conditions are valid.
        /// </summary>
        public bool BothValid
        {
            get => _bothValid;
            set => _bothValid = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        /// <remarks>This constructor sets up the form by initializing its components and setting the
        /// title text to "Abigail Sneve Assignment 4".</remarks>
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Sets the values of <see cref="WordOne"/> and <see cref="WordTwo"/> based on the text input,  and determines
        /// whether both words are valid.
        /// </summary>
        /// <remarks>This method retrieves the text from the associated text boxes and updates the  <see
        /// cref="BothValid"/> property to indicate whether the words meet the validation criteria.</remarks>
        private void SetWords()
        {
            WordOne = FirstWordTextBox.Text;
            WordTwo = SecondWordTextBox.Text;
            BothValid = Driver.AreBothValid(WordOne, WordTwo);
        }

        /// <summary>
        /// Handles the click event for the Word Metrics button.
        /// </summary>
        /// <remarks>Updates the <c>OutputLbl</c> with the word metrics if both words are valid.  If the
        /// words are invalid, displays an error message prompting the user to enter valid words.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void WordMetricsButton_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_wordOne != null)
                if (_wordTwo != null)
                    OutputLbl.Text = _bothValid
                        ? Driver.GetWordMetrics(_wordOne, _wordTwo)
                        : "Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the WordSquare button.
        /// </summary>
        /// <remarks>Updates the <see cref="OutputLbl"/> text to display word squares for the provided
        /// words if both words are valid. If the words are not valid, displays an error message.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void WordSquareButton_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_bothValid)
            {
                if (_wordOne != null)
                    if (_wordTwo != null)
                        OutputLbl.Text = Driver.GetWordSquare(_wordOne) + @"
" + Driver.GetWordSquare(_wordTwo);
            }
            else
                OutputLbl.Text = @"Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the WordPyramidButton.
        /// </summary>
        /// <remarks>If both words are valid, this method generates word pyramids for the two words and
        /// displays them in the output label. Otherwise, it displays an error message prompting the user to enter two
        /// valid words.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void WordPyramidButton_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_bothValid)
            {
                if (_wordOne != null)
                    if (_wordTwo != null)
                        OutputLbl.Text = Driver.GetWordPyramid(_wordOne) + @"
" + Driver.GetWordPyramid(_wordTwo);
            }
            else
                OutputLbl.Text = @"Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the WordPalindromeButton, determining whether the provided words are
        /// palindromes.
        /// </summary>
        /// <remarks>This method checks if two words are valid and determines whether each word is a
        /// palindrome. The results are displayed in the <see cref="OutputLbl"/> control. If the words are not valid, an
        /// error message is displayed instead.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void WordPalindromeButton_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_bothValid)
            {
                OutputLbl.Text = "";
                OutputLbl.Text += _wordOne != null && Driver.IsPalindrome(_wordOne)
                    ? $"{_wordOne} is a palindrome.\n"
                    : $"{_wordOne} is not a palindrome.\n";
                OutputLbl.Text += _wordTwo != null && Driver.IsPalindrome(  _wordTwo)
                    ? $"{_wordTwo} is a palindrome.\n"
                    : $"{_wordTwo} is not a palindrome.\n";
            }
            else
                OutputLbl.Text = @"Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event of the "Letter Checker" button.
        /// </summary>
        /// <remarks>This method compares two words, <see cref="OutputLbl"/> and <see cref="sender"/>, to
        /// determine the letters they have in common. If both words are valid, it displays the common letters in the
        /// <see cref="e"/> label. If no common letters are found, it indicates that the words have no letters
        /// in common. If the words are not valid, it prompts the user to enter valid words.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="_wordTwo"/> instance containing the event data.</param>
        private void LetterCheckerButton_Click(object sender, EventArgs e)
        {
            SetWords();
            if (_wordOne != null)
                if (_wordTwo != null)
                    OutputLbl.Text = Driver.GetCommonLetters(_wordOne, _wordTwo);
        }

        /// <summary>
        /// Handles the click event for the "Word Multiply" button, multiplying two numbers represented as words.
        /// </summary>
        /// <remarks>This method validates that both input words represent numbers between zero and ten.
        /// If valid, it converts the words to their numeric equivalents, calculates their product, and displays the
        /// result. If the inputs are invalid, an error message is displayed.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void WordMultiplyButton_Click(object sender, EventArgs e)
        {
            SetWords();
            if (_wordOne != null)
                if (_wordTwo != null)
                    OutputLbl.Text = Driver.GetMultiplication(_wordOne, _wordTwo);
        }

        /// <summary>
        /// Handles the click event for the "Metrics" menu item.
        /// </summary>
        /// <remarks>Updates the <see cref="OutputLbl"/> control with the word metrics if both words are
        /// valid. If the words are not valid, displays an error message prompting the user to enter valid
        /// words.</remarks>
        /// <param name="sender">The source of the event, typically the "Metrics" menu item.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void metricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWords();
            OutputLbl.Text = _bothValid
                ? Driver.GetWordMetrics(_wordOne, _wordTwo)
                : "Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the "Letter" menu item. Determines and displays the common letters between two
        /// words if both words are valid.
        /// </summary>
        /// <remarks>If both words are valid, the method identifies the unique letters that are common to
        /// both words, ignoring case, and displays them. If no common letters are found, a message indicating this is
        /// displayed. If the words are not valid, an error message is shown.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWords();
            if (_wordTwo != null) OutputLbl.Text = Driver.GetCommonLetters(_wordOne, _wordTwo);
        }

        /// <summary>
        /// Handles the click event for the "Square" menu item.  Displays word squares based on the provided input words
        /// if they are valid.
        /// </summary>
        /// <remarks>If the input words are valid, their corresponding word squares are displayed in the
        /// output label. Otherwise, an error message is shown prompting the user to enter valid words.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_bothValid)
            {
                if (_wordOne != null)
                    if (_wordTwo != null)
                        OutputLbl.Text = Driver.GetWordSquare(_wordOne) + @"
" + Driver.GetWordSquare(_wordTwo);
            }
            else
                OutputLbl.Text = @"Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the "Pyramid" menu item.
        /// </summary>
        /// <remarks>This method updates the <c>OutputLbl</c> control with the word pyramids for two valid
        /// words if both are valid. If the words are not valid, it displays an error message prompting the user to
        /// enter valid words.</remarks>
        /// <param name="sender">The source of the event, typically the menu item that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void pyramidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_bothValid)
            {
                if (_wordOne != null)
                    if (_wordTwo != null)
                        OutputLbl.Text = Driver.GetWordPyramid(_wordOne) + @"
" + Driver.GetWordPyramid(_wordTwo);
            }
            else
                OutputLbl.Text = @"Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the "Palindrome" menu item.
        /// </summary>
        /// <remarks>This method checks whether two words are palindromes and updates the output label
        /// with the results. If the input words are invalid, an error message is displayed instead.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void palindromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWords();

            if (_bothValid)
            {
                OutputLbl.Text = "";
                OutputLbl.Text += _wordOne != null && Driver.IsPalindrome(_wordOne)
                    ? $"{_wordOne} is a palindrome.\n"
                    : $"{_wordOne} is not a palindrome.\n";
                OutputLbl.Text += _wordTwo != null && Driver.IsPalindrome(_wordTwo)
                    ? $"{_wordTwo} is a palindrome.\n"
                    : $"{_wordTwo} is not a palindrome.\n";
            }
            else
                OutputLbl.Text = @"Please enter two valid words.";
        }

        /// <summary>
        /// Handles the click event for the "Multiply" menu item. Converts two words representing numbers  into their
        /// numeric equivalents, multiplies them, and displays the result.
        /// </summary>
        /// <remarks>This method expects the words represented by <c>WordOne</c> and <c>WordTwo</c> to be
        /// valid  numeric words between "zero" and "ten" (inclusive). If either word is invalid, an error message  is
        /// displayed. The result of the multiplication is shown in the <c>OutputLbl</c> label.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWords();
            if (_wordTwo != null)
                if (_wordOne != null)
                    OutputLbl.Text = Driver.GetMultiplication(_wordOne, _wordTwo);
        }

    }
}
