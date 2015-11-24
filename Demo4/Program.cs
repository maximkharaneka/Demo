using System;

namespace Demo4
{
    internal class Program
    {
        public static int SumOfPairs(int[] numbersArray, int numberToFind)
        {
            var count = 0;
            Array.Sort(numbersArray);
            foreach (var number in numbersArray)
            {
                var index = Array.BinarySearch(numbersArray, numberToFind - number);
                if (index > 0)
                {
                    count++;
                }
            }
            return count;
        }

        private static void Main(string[] args)
        {
            int[] numbersArray = {1, 2, 3, 4, 5, 10, 11, 13, 78};
            var numberToFind = 15;
            var count = SumOfPairs(numbersArray, numberToFind);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}