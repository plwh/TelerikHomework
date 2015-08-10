// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Text;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        string strRegex = @"[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}";
        Regex myRegex = new Regex(strRegex, RegexOptions.None);
        string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984.";
        Console.Write("We are given text:\n\n{0}\n\n",text);
        Console.WriteLine("Extracted dates in the standard format for Canada:\n");
        foreach (Match myMatch in myRegex.Matches(text))
        {
            if (myMatch.Success)
            {
                Console.WriteLine(myMatch);
            }
        }
        Console.WriteLine();
    }
}

