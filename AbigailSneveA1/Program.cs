
namespace AbigailSneveA1
{/// our main class in this program
    internal class Program
    {
        /// <summary>
        /// //string to hold first word
        /// </summary>
        public string? WordOne { get; set; }
        /// <summary>
        /// string to hold second word
        /// </summary>
        public string? WordTwo { get; set; }
        /// <summary>
        /// string to hold first word length
        /// </summary>
        public int WordOneLength { get; set; }
        /// <summary>
        /// string to hold second word length
        /// </summary>
        public int WordTwoLength { get; set; }

        /// <summary>
        /// Entry point of the program.
        /// </summary>
        public static void Main(string[] args)
        {
            var myDriver = new Program();

            myDriver.Run();
        }

        /// <summary>
        /// Driver for Program
        /// </summary>
        public void Run()
        {
            LoopProgram();
        }
        /// <summary>
        /// Prompts the user to input two words, converts them to lowercase, and assigns them to the corresponding
        /// word properties.
        /// </summary>

        public void GetWords()
        {
            while (WordOne == null || WordOne.All(char.IsDigit) || WordOne.Contains(" "))
            {
                Console.WriteLine("Please enter the first of two words: \n");

                WordOne = Console.ReadLine();
            }
            while (WordTwo == null || WordTwo.All(char.IsDigit)  || WordTwo.Contains(" "))
            {
                Console.WriteLine("Please enter the second of two words: \n");
                WordTwo = Console.ReadLine();

            }
            WordOne = WordOne.ToLower();
            WordTwo = WordTwo.ToLower();
        }
        /// <summary>
        /// Displays the lengths of the words stored in the "WordOne" and "WordTwo".
        /// </summary>

        public void GetWordLength()
        {
            if (WordOne == null || WordTwo == null)
            {
                Console.WriteLine("Words have not been set. Please set the words before getting their lengths.");
                return;
            }
            WordOneLength = WordOne.Length;
            WordTwoLength = WordTwo.Length;
            Console.WriteLine("Word One: \n" + WordOne + "; Length: " + WordOneLength + " \n");
            Console.WriteLine("Word Two \n" + WordTwo + "; Length: " + WordTwoLength + " \n");

            if (WordOneLength > WordTwoLength)
            {
                Console.WriteLine(WordOne + " is longer than " + WordTwo + "\n");
            }
            else if (WordOneLength < WordTwoLength)
            {
                Console.WriteLine(WordTwo + " is longer than " + WordOne + "\n");
            }
            else
            {
                Console.WriteLine(WordOne + " and " + WordTwo + " are the same length.\n");
            }
        }
        /// <summary>
        /// Displays the words "WordOne" and "WordTwo" as repeated lines,  with each word
        /// printed a number of times equal to its length.
        /// </summary>
    
        public void MakeWordSquare()
        {
            for (int i = 0; i < WordOne.Length; i++)
            {
                Console.WriteLine(WordOne);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < WordTwo.Length; i++)
            {
                Console.WriteLine(WordTwo);
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Generates and displays a pyramid-like pattern for two words.
        /// </summary>

        public void MakeWordPyramid()
        {

            for (int i = 0; i < WordOneLength; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(WordOne[j]);
                }
                Console.WriteLine();
            }


            for (int i = WordOneLength - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(WordOne[j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < WordTwoLength; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(WordTwo[j]);
                }
                Console.WriteLine();
            }

            for (int i = WordTwoLength - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(WordTwo[j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        /// <summary>
        ///     checks if the words stored in "WordOne"  and  "WordTwo" to see if they are palindromes
        /// </summary>
        public void CheckPalindrome()
        {
            bool isWordOnePalindrome = $"{WordOne}" == new string(WordOne.Reverse().ToArray());
            bool isWordTwoPalindrome = $"{WordTwo}" == new string(WordTwo.Reverse().ToArray());

            if (isWordOnePalindrome)
            {
                Console.WriteLine(WordOne + " is a palindrome.\n");
            }
            else
            {
                Console.WriteLine(WordOne + " is not a palindrome.\n");
            }

            if (isWordTwoPalindrome)
            {
                Console.WriteLine(WordTwo + " is a palindrome.\n");
            }
            else
            {
                Console.WriteLine(WordTwo + " is not a palindrome.\n");
            }
        }
        /// <summary>
        /// loops the program until user says 'y' to quit
        /// </summary>
        public void LoopProgram()
        {
            while (true)
            {
                var answer = "";
                Console.WriteLine("would you like to exit? (y/n)");
                answer = Console.ReadLine();
                if (answer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                GetWords();
                GetWordLength();
                MakeWordSquare();
                MakeWordPyramid();
                CheckPalindrome();
            }
        }
    }
}
