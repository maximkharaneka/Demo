using System;
using System.Text;

namespace Demo3
{
    internal class Program
    {
        public static int ConvertAsciiToInt(byte code)
        {
            var outputInt = code - 48;
            if (0 > outputInt || outputInt > 9)
                throw new FormatException("Input string was not in a correct format.");
            return outputInt;
        }

        public static int ConvertTextToInt(string text)
        {
            var parsedText = 0;
            var power = 1;
            var asciiBytes = Encoding.ASCII.GetBytes(text);
            for (var i = asciiBytes.Length - 1; i >= 0; i--)
            {
                parsedText += ConvertAsciiToInt(asciiBytes[i])*power;
                power = power*10;
            }

            return parsedText;
        }

        private static void Main(string[] args)
        {
            var value = "9quali52ty3";
            try
            {
                var intParseValue = int.Parse(value);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("int.Parse raises FormatException");
            }
            try
            {
                var intValue = ConvertTextToInt(value);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ConvertTextToInt raises FormatException");
            }

            var value2 = "0123456789";
            var intParseValue2 = int.Parse(value2);
            var intValue2 = ConvertTextToInt(value2);
            Console.WriteLine(intParseValue2);
            Console.WriteLine(intValue2);
            Console.ReadLine();
        }
    }
}