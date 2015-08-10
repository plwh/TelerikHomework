// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Text;
using System.Collections.Generic;

class WordAsDictionary
{
    static void Main()
    {
        string text = @".NET-platform for applications from Microsoft
CLR-managed execution environment for .NET
namespace-hierarchical organization of classes";
        char[] separators = { '\n', '-' };
        string[] arrDictionary = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var dictionary = new Dictionary<string, string>();
        for (int i = 0; i < arrDictionary.Length; i += 2)
        {
            dictionary.Add(arrDictionary[i], arrDictionary[i + 1]);
        }
        Console.Write("Enter a word:");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine(dictionary[word]);
        }
        else
        {
            Console.WriteLine("Dictionary has no entry for {0}.",word);
        }
    }
}

