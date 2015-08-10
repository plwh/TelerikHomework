// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
// the rest of the characters should be filled with *. Print the result string into the console.

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        string result = input;
        if (input.Length > 20)
        {
            Console.WriteLine("Maximum length of string is 20 characters.");
            return;
        }
        else if (input.Length < 20)
        {
            result = input.PadRight(20, '*');
            Console.WriteLine("Result:{0}", result);
        }
        else
        {
            Console.WriteLine("Result:{0}", result);
        }
    }
}
