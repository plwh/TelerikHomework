// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;

class Palindromes
{
    public static bool isPalindrome(char[] word)
    {
        int i1 = 0;
        int i2 = word.Length - 1;
        while (i2 > i1)
        {
            if (word[i1] != word[i2])
            {
                return false;
            }
            ++i1;
            --i2;
        }
        return true;
    }
    static void Main()
    {
        string text = @"ABBA was a Swedish pop group formed in Stockholm in 1972.
.exe is a common filename extension denoting an executable file for DOS, OpenVMS, Microsoft Windows, Symbian or OS/2. ";
        Console.WriteLine("We are given text:\n\n{0}\n", text);
        string[] words = text.Split(' ',',','.');
        StringBuilder palindromes = new StringBuilder();
        Console.WriteLine("Palindromes in text:\n");
        foreach (string word in words)
        {
            char[] characters = word.ToCharArray();
            if (isPalindrome(characters))
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine("\n");
    }
}

