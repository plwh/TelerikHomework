// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        Console.WriteLine("We are given file \"names.txt\"(located in the main folder of this project)");
        StreamReader reader = new StreamReader("../../names.txt");
        StreamWriter writer = new StreamWriter("output.txt");
        string[] names = new string[File.ReadAllLines("../../names.txt").Length];
        for(int i = 0; i < names.Length; i++)
        {
            names[i] = reader.ReadLine();
        }
        Array.Sort(names);
        using (writer)
        {
            Console.WriteLine(@"Strings have been sorted.
Output (output.txt) can be found in the bin\Debug folder of this project.");
            for(int j = 0; j < names.Length; j++)
            {
                writer.WriteLine(names[j]);
            }
        }
    }
}

