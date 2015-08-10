// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string strRegex = @"[A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?";
        Regex myRegex = new Regex(strRegex, RegexOptions.None);
        string text = @"Please contact us by phone (+001 222 222 222) or by email at example@gmail.com 
or at user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. 
Neither this: a@a.b.";
        Console.WriteLine("We are given text:\n\n{0}\n", text);
        Console.Write("Email addresses from text:\n\n");
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

