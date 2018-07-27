namespace _008.AgeAfterTenYears
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AgeAfterTenYears
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write your birth day (in the format day/month/year)");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
        }
    }
}
