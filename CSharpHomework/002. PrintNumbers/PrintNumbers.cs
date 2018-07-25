namespace _002.PrintNumbers
{
    using System;

    public class PrintNumbers
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 4)
            {
                Console.WriteLine(Convert.ToString(i, 2));
            }
        }
    }
}

// Write a program to print the numbers 1, 101 and 1001, each at a separate line.