namespace _002.TaumAndBday
{
    using System;
    using System.Linq;

    public class TaumAndBday
    {
        public static void Main()
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputLines; i++)
            {
                int[] firstLine = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                int numberOfBlackRequired = firstLine[0];
                int numberOfWhiteRequired = firstLine[1];
                int[] secondLine = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                int blackGiftCost = secondLine[0];
                int whiteGiftCost = secondLine[1];
                int convertingCost = secondLine[2];

                if (whiteGiftCost < blackGiftCost && (whiteGiftCost + convertingCost) < blackGiftCost)
                {
                    long finalCost = ((long)whiteGiftCost * numberOfWhiteRequired) + (((long)whiteGiftCost + convertingCost) * numberOfBlackRequired);
                    Console.WriteLine(finalCost);
                }
                else if (blackGiftCost < whiteGiftCost && (blackGiftCost + convertingCost) < whiteGiftCost)
                {
                    long finalCost = ((long)blackGiftCost * numberOfBlackRequired) + (((long)blackGiftCost + convertingCost) * numberOfWhiteRequired);
                    Console.WriteLine(finalCost);
                }
                else
                {
                    long finalCost = ((long)numberOfBlackRequired * blackGiftCost) + ((long)numberOfWhiteRequired * whiteGiftCost); 
                    Console.WriteLine(finalCost);
                }
            }
        }
    }
}
