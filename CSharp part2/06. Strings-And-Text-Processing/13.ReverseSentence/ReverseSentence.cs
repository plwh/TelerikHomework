// Write a program that reverses the words in given sentence.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        string str = "C# is not C++, not PHP and not Deplhi!";
        Console.WriteLine("We are given sentence:\n{0}", str);
        char lastChar = str[str.Length - 1];
        str = str.Substring(0, str.Length - 1); 
        string[] words = str.Split(' ');
        List<int> commas = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(","))
            {
                commas.Add(i);
                words[i] = words[i].Substring(0, words[i].Length - 1);
            }
        }
        Array.Reverse(words);
        if (commas.Count > 0)
        {
            for (int i = 0; i < commas.Count; i++)
            {
                words[commas[i]] += ',';
            }
        }
        string strReversed = String.Join(" ", words) + lastChar;
        Console.WriteLine("Sentence reversed:\n{0}",strReversed);
    }
}

