// Write a program that reads a string from the console and lists all different words in the string along with information 
// how many times each word is found.

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ', ',', '.');
        var dictionary = new Dictionary<string, int>();
        int count = 0;
        for (int i = 0; i < words.Length; i ++)
        {
            if (words[i] == "" || words[i] == ".")
            {
                continue;
            }
            else if (dictionary.ContainsKey(words[i]))
            {
                dictionary.TryGetValue(words[i], out count);
                dictionary[words[i]] = count + 1;
            }
            else
            {
                dictionary.Add(words[i], count = 1);
            }
        }
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine("Word: {0}  Occurences: {1}",
                kvp.Key, kvp.Value);
        }
    }
}

