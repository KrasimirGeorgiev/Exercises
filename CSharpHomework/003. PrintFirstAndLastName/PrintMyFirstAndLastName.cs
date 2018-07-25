namespace _003.PrintFirstAndLastName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PrintMyFirstAndLastName
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your fist name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter you last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("{0}\n{1}", firstName, lastName);
        }
    }
}

// Create console application that prints your first and last name, each at a separate line.