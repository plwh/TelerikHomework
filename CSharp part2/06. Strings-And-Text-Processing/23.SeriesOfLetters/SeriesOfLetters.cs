// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        StringBuilder nonRepeatingLetters = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (i == input.Length - 1)
            {
                nonRepeatingLetters.Append(input[i]);
                break;
            }
            else if (input[i] == input[i + 1])
            {
                continue;
            }
            else
            { 
                nonRepeatingLetters.Append(input[i]);
            }
        }
        Console.Write("Output:");
        for (int j = 0; j < nonRepeatingLetters.Length;j++)
        {
            Console.Write(nonRepeatingLetters[j]);
        }
        Console.WriteLine();
    }
}
