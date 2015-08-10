// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Text.RegularExpressions;
using System.IO;

class PrefixTest
{
    static void Main()
    {
        Console.WriteLine("Enter full path of text file:");
        string input = Console.ReadLine();
        string text = File.ReadAllText(input);
        string pattern = @"\btest\w*\b";
        text = Regex.Replace(text, pattern,"");
        Console.WriteLine("All words in text file beginning with prefix \"test\" have been removed. Result is in the same file.");
        File.WriteAllText(input, text);
    }
}
