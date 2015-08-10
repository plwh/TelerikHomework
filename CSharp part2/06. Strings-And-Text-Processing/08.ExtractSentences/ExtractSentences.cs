// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine("The text is:\n{0}", text);
        Console.WriteLine("The word is: in");
        string subString = " in "; // you can change the word for different result
        string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");
        Console.WriteLine("Result:");
        foreach (string sentence in sentences)
        {
            if (Regex.Matches(sentence, subString, RegexOptions.IgnoreCase).Count != 0)
            { 
                Console.Write(sentence+" ");
            }
        }
        Console.WriteLine();
    }
}

