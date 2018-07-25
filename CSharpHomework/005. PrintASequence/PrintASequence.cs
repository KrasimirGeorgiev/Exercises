namespace _005.PrintASequence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PrintASequence
    {
        public static void Main(string[] args)
        {
            List<int> integerSequence = new List<int>();
            for (int i = 2; i < 12; i++)
            {
                int currNumber = i;
                if (currNumber % 2 != 0)
                {
                    currNumber *= -1;
                }

                integerSequence.Add(currNumber);
            }

            Console.WriteLine(string.Join(", ", integerSequence));
        }
    }
}

// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...