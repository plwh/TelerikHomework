// Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        Console.WriteLine("We are given file \"text.txt\"(located in the main folder of this project)");
        string[] lines = File.ReadAllLines("../../text.txt");
        Console.WriteLine("File contents before edit:");
        for (int index = 0; index < lines.Length; index++)
        {
            Console.WriteLine(lines[index]);
        }
        using (StreamWriter streamWriter = new StreamWriter("../../text.txt"))
        {
            for (int index = 1 ; index < lines.Length; index+=2)
            {         
                streamWriter.WriteLine(lines[index]);
            }
            Console.WriteLine("Odd lines in text file have been removed. Result is in the same file.");
        }
    }
}

