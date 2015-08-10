// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

 class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length-1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        Console.WriteLine("String reversed:{0}", reversed);
    }
}

