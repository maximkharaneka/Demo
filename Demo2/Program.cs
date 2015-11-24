using System;
using System.Linq;

namespace Demo2
{
    internal class Program
    {
        public static string RevertText(string text)
        {
            var splittedText = text.ToLower().Split(' ');
            var revertedText = splittedText.Reverse().Aggregate((current, next) => current + " " + next);
            return revertedText;
        }

        private static void Main(string[] args)
        {
            var string1 = "This is a nice day!";
            var string2 = "This is a another beautiful, nice day!";
            Console.WriteLine(RevertText(string1));
            Console.WriteLine(RevertText(string2));
            Console.ReadLine();
        }
    }
}