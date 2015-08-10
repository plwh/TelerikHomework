// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Text;

class ForbiddenWords
{
    static string ReplaceForbiddenWords(string text,string[]words)
    {
        StringBuilder result = new StringBuilder (text);
        foreach (string word in words)
        {
            string replacement = "";
            result.Replace(word,replacement.PadRight(word.Length,'*'));
        }
        return result.ToString();
    }
    static void Main()
    { 
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("We are given text:\n{0}",text);
        Console.WriteLine("Forbidden words: PHP, CLR, Microsoft");
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };      
        Console.WriteLine("Forbidden words replaced with *:\n{0}",ReplaceForbiddenWords(text, forbiddenWords));
    }
}

