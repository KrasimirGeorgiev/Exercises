namespace _005.Encription
{
    using System;
    using System.Text;

    public class Encryption
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int inputLength = input.Length;
            int maxL = (int)Math.Ceiling(Math.Sqrt(inputLength));
            int minL = (int)Math.Floor(Math.Sqrt(inputLength));
            int rowsLength = minL;
            int colsLength = maxL;
            if (rowsLength * rowsLength >= inputLength)
            {
                colsLength = rowsLength;
            }
            else if (rowsLength * colsLength >= inputLength)
            {
            }
            else
            {
                rowsLength = colsLength;
            }

            char[,] matrix = new char[rowsLength, colsLength];
            int count = 0;
            for (int rows = 0; rows < rowsLength; rows++)
            {
                for (int cols = 0; cols < colsLength; cols++)
                {
                    if (count >= inputLength)
                    {
                        matrix[rows, cols] = '0';
                        continue;
                    }

                    matrix[rows, cols] = input[count];
                    count++;
                }
            }

            StringBuilder result = new StringBuilder();
            for (int cols = 0; cols < colsLength; cols++)
            {
                for (int rows = 0; rows < rowsLength; rows++)
                {
                    char currentChar = matrix[rows, cols];
                    if (currentChar != '0')
                    {
                        result.Append(currentChar.ToString());
                    }
                }

                result.Append(" ");
            }

            result.Length = result.Length - 1;

            Console.WriteLine(result.ToString());
        }
    }
}

// An English text needs to be encrypted using the following encryption scheme.
// First, the spaces are removed from the text.Let L be the length of this text.
// Then, characters are written into a grid, whose rows and columns have the following constraints:
// 
// For example, the sentence if man was meant to stay on the ground god would have given us roots after removing spaces is 5454 characters long, so it is written in the form of a grid with 7 rows and 8 columns.
// 
// ifmanwas
// meanttos
// tayonthe
// groundgo
// dwouldha
// vegivenu
// sroots
// Ensure that rows×columns≥L
// If multiple grids satisfy the above conditions, choose the one with the minimum area, i.e.rows×columnsrows×columns.
// The encoded message is obtained by displaying the characters in a column, inserting a space, and then displaying the next column and inserting a space, and so on.For example, the encoded message for the above rectangle is:
// 
// imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau
// 
// 
// You will be given a message in English with no spaces between the words.The maximum message length can be 8181 characters.Print the encoded message.
// 
// 
// Here are some more examples:
// 
// Sample Input:
// haveaniceday
// Sample Output:
// hae and via ecy
// Sample Input:
// feedthedog
// Sample Output:
// fto ehg ee dd
// Sample Input:
// chillout
// Sample Output:
// clu hlt io
