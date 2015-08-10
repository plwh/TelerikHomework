// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Text;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        string str = @" We are living in an yellow submarine. We don't have anything else. inside the
submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(str);
        Console.Write("Enter target sub-string:");
        string subString = Console.ReadLine();
        int count = Regex.Matches(str, subString,RegexOptions.IgnoreCase).Count;
        Console.WriteLine("The result is: {0}", count);
    }
}

