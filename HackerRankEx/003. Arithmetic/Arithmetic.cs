namespace _003.Arithmetic
{
    using System;

    public class Arithmetic
    {
        public static void Main()
        {
            decimal basePrice = decimal.Parse(Console.ReadLine());
            decimal tipPercent = decimal.Parse(Console.ReadLine());
            decimal taxPercent = decimal.Parse(Console.ReadLine());
            decimal tipPrice = CalculatePercentageOfPrice(tipPercent, basePrice);
            decimal taxPrice = CalculatePercentageOfPrice(taxPercent, basePrice);
            decimal finalPrice = basePrice + tipPrice + taxPrice;

            Console.WriteLine("The final price of the meal is ${0}.", Math.Round(finalPrice));
        }

        private static decimal CalculatePercentageOfPrice(decimal percent, decimal price)
        {
            decimal result = (percent * price) / 100;
            return result;
        }
    }
}

// In this problem, we read as input the original price of the meal, tip percentage, and tax percentage. 
// The output must be a string stating: "The final price of the meal is {finalPrice}."
// The final price must be rounded to the nearest integer.