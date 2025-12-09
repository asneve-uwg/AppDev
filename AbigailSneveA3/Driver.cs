using System.Text;

namespace AbigailSneveA4
{
    public static class Driver
    {


        private static readonly HashSet<string> AllowedNumbers = new()
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
        };

        public static bool AreBothValid(string? wordOne, string wordTwo)
        {
            return !string.IsNullOrWhiteSpace(wordOne) && !string.IsNullOrWhiteSpace(wordTwo);
        }

        public static string GetWordMetrics(string? wordOne, string? wordTwo)
        {
            string result = "";
            if (wordOne != null)
            {
                var wordOneLength = wordOne.Length;
                if (wordTwo != null)
                {
                    var wordTwoLength = wordTwo.Length;
                    result = $"Word One: \n{wordOne}; Length: {wordOneLength} \n";
                    result += $"Word Two \n{wordTwo}; Length: {wordTwoLength} \n";

                    if (wordOneLength > wordTwoLength)
                        result += $"{wordOne} is longer than {wordTwo}\n";
                    else if (wordOneLength < wordTwoLength)
                        result += $"{wordTwo} is longer than {wordOne}\n";
                    else
                        result += $"{wordOne} and {wordTwo} are the same length.\n";
                }
            }

            return result;

        }

        public static string GetWordSquare(string word)
        {
            return string.Join("\n", Enumerable.Repeat(word, word.Length)) + "\n";
        }

        public static string GetWordPyramid(string word)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                sb.AppendLine(word.Substring(0, i + 1));
            }

            for (int i = word.Length - 2; i >= 0; i--)
            {
                sb.AppendLine(word.Substring(0, i + 1));
            }

            return sb.ToString();
        }

        public static bool IsPalindrome(string word)
        {
            return word == new string(word.Reverse().ToArray());
        }

        public static string GetCommonLetters(string? wordOne, string wordTwo)
        {
            string result = "";
            if (AreBothValid(wordOne, wordTwo))
            {
                string common = "";
                foreach (var c in (wordOne?.ToLower()).Where(c => wordTwo.ToLower().Contains(c) && !common.Contains(c)))
                {
                    common += c + " ";
                }

                if (common.Length > 0)
                {
                    result +=
                        ($@"The words {wordOne} and {wordTwo} have the following letters in common: 
 {common}
");

                }
                else
                {
                    result += ($@"The words {wordOne} and {wordTwo} have no letters in common.
");
                }
            }
            else
            {
                result = (@"Please enter two valid words.");
            }
            return result;
        }

        public static string GetMultiplication(string wordOne, string wordTwo)
        {

            string result;
            if (AllowedNumbers.Contains(wordOne.Trim().ToLower()) && AllowedNumbers.Contains(wordTwo.Trim().ToLower()))
            {
                int? num1 = WordToNumber(wordOne);
                int? num2 = WordToNumber(wordTwo);

                if (num1.HasValue && num2.HasValue)
                {
                    int product = num1.Value * num2.Value;
                   result = ($@"{wordOne} * {wordTwo} = {product}");
                }
                else
                {
                    result = (@"error");
                }
            }
            else
            {
                result = (@"Both words must be numbers between zero and ten.");
            }

            return result;
        }
    


    public static int? WordToNumber(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return null;
            switch (word.Trim().ToLower())
            {
                case "zero": return 0;
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                case "ten": return 10;
                default: return null;
            }
        }
    }
}
