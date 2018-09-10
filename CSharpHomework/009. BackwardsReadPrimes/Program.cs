namespace _009.BackwardsReadPrimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BackwardsPrime(2, 100));
            Console.WriteLine(BackwardsPrime(9900, 10000));
        }

        public static string BackwardsPrime(long start, long end)
        {
            List<string> resultCollection = new List<string>();
            for (long i = start; i <= end; i++)
            {
                if (NumberIsBackwardsPrime(i)) resultCollection.Add(i.ToString());
            }

            return string.Join(" ", resultCollection);
        }

        private static bool NumberIsPrime(long number)
        {
            if (number <= 1 || number % 2 == 0) return false;
            if (number == 2) return true;

            var range = Math.Sqrt(number);
            for (int i = 3; i <= range; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static bool NumberIsBackwardsPrime(long number)
        {
            if (NumberIsPrime(number))
            {
                long backwardsNumber = long.Parse(string.Join("", number.ToString().ToCharArray().Reverse()));

                if (number != backwardsNumber && NumberIsPrime(backwardsNumber))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

// Excercise: find all numbers in a given range that are backwards prime
// number is backwards prime is the number is prime and when read backwards the new number is also prime
