namespace _001.PrintYourName
{
    using System;

    public class PrintMyName
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }
}

// Print Your Name