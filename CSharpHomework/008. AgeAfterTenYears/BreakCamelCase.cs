namespace _008.AgeAfterTenYears
{
    using System;
    using System.Text.RegularExpressions;

    public class BreakCamelCase
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(AddSpaceBeforeCapitalCaseLatinLetter("abdsfBadf"));

        }

        public static string AddSpaceBeforeCapitalCaseLatinLetter(string str) => new Regex("([A-Z])").Replace(str, " $1");
    }
}
