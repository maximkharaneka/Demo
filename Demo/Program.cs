using System;

namespace Demo
{
    internal class Program
    {
        public static bool ValidateText(string text)
        {
            var bracketCount = 0;
            foreach (var symbol in text)
            {
                switch (symbol)
                {
                    case '[':
                        bracketCount++;
                        break;

                    case ']':
                        bracketCount--;
                        break;
                }
                if (bracketCount < 0)
                {
                    break;
                }
            }
            var isValid = (bracketCount == 0);

            return isValid;
        }

        private static void Main(string[] args)
        {
            var string1 = "[This is a text [this is subtext]] is valid";
            var string2 = "[This is a text[this is ] a subtext is not valid";
            Console.WriteLine(ValidateText(string1));
            Console.WriteLine(ValidateText(string2));
            Console.ReadLine();
        }
    }
}