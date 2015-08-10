/* Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array. */

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] charArray = new char[26];
        for (int i = 0, p = 65; i < charArray.Length; i++, p++)
        {
            charArray[i] = (char)p;
        }
        Console.Write("Enter a word containing letters from A to Z:");
        string word = Console.ReadLine();
        for (int j = 0;j < word.Length;j++)
        {
            for (int k=0;k < charArray.Length;k++)
            {
                if (word[j] == charArray[k])
                {
                    Console.WriteLine("Letter "+word[j]+" has array index "+k);
                    break;
                }
            }
        }
    }
}

