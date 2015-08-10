// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        Console.WriteLine("We are given file \"lines.txt\"(located in the main folder of this project)");
        string[] lines = System.IO.File.ReadAllLines("../../lines.txt");
        Console.WriteLine("Odd lines in file:");
        for (int i = 0; i < lines.Length; i += 2)
        {
            Console.WriteLine(lines[i]);
        }
    }
}

