namespace _004.SquareRoot
{
    using System;

    public class FindSquareRoot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Square root of {0}", inputNumber);
            Console.WriteLine(FindSquareRootOfInt(inputNumber));
        }

        public static long FindSquareRootOfInt(int n)
        {
            return (long)n * n;
        }
    }
}

// Create a console application that calculates and prints the square root of the number 12345