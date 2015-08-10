// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        char[] originalString = input.ToCharArray();
        StringBuilder unicodeString = new StringBuilder(); 
        foreach (char c in originalString)
        {
            int cint = Convert.ToInt32(c);
            unicodeString.Append(String.Format("\\u{0:x4} ", cint).Trim());
        }
        Console.WriteLine("Result:{0}", unicodeString);

    }
}

