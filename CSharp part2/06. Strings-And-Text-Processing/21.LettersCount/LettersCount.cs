// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Text;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        int [] occurence = new int[123];
        for (int i = 0; i < input.Length; i++)
        {
            if (((int)input[i] >= 65 && (int)input[i] <= 90) || ((int)input[i] >= 97 && (int)input[i] <= 122))
            {
                occurence[(int)input[i]] += 1;
            }
            else
            {
                continue;
            }    
        }
        Console.WriteLine("Letter" + "   " + "Number of occurences");
        for (int j = 0; j < occurence.Length; j++)
        {
            if (occurence[j] != 0)
            { 
                Console.WriteLine("  "+(char)j + "\t\t" + occurence[j]);
            }
        }
    }
}

