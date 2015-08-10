// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text;
using System.Text.RegularExpressions;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words (separated by space):");
        string input = Console.ReadLine();
        string [] wordsSeparated = Regex.Split(input," ");
        Array.Sort(wordsSeparated);
        Console.WriteLine("Words in alphabetical order:");
        foreach (string word in wordsSeparated)
        {
            Console.WriteLine(word);
        }
    }
}

