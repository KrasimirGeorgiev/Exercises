namespace _004.IfElseStatements
{
    using System;

    public class IfElseStatements
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            bool numberIsEven = CheckIfNumberIsEven(inputNumber);

            if (!numberIsEven)
            {
                Console.WriteLine("Weird");
            }
            else if (numberIsEven && CheckIfNumberIsInRangeInclusive(inputNumber, 2, 5))
            {
                Console.WriteLine("Not Weird");
            }
            else if (numberIsEven && CheckIfNumberIsInRangeInclusive(inputNumber, 6, 20))
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }

        private static bool CheckIfNumberIsEven(int number)
        {
            bool numberIsEven = false;
            if (number % 2 == 0)
            {
                numberIsEven = true;
            }

            return numberIsEven;
        }

        private static bool CheckIfNumberIsInRangeInclusive(int baseNumber, int firstRangeNumber, int secondRangeNumber)
        {
            bool numberIsInRange = false;
            int minRangeNumber = Math.Min(firstRangeNumber, secondRangeNumber);
            int maxRangeNumber = Math.Max(firstRangeNumber, secondRangeNumber);
            if (minRangeNumber <= baseNumber && baseNumber <= maxRangeNumber)
            {
                numberIsInRange = true;
            }

            return numberIsInRange;
        }
    }
}

// Given an integer N as input, check the following:
// If N is odd, print "Weird".
// If N is even and, in between the range of 2 and 5(inclusive), print "Not Weird".
// If N is even and, in between the range of 6 and 20(inclusive), print "Weird".
// If N is even and N>20, print "Not Weird".