// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        Console.WriteLine("We are given file \"text.txt\"(located in the main folder of this project)");
        StreamReader streamReader = new StreamReader("../../text.txt");
        StreamWriter streamWriter = new StreamWriter("result.txt");
        using (streamWriter)
        {
            for (int lineNumber = 1; lineNumber <= File.ReadAllLines("../../text.txt").Length; lineNumber++)
            {
   
                streamWriter.WriteLine("Line {0}: {1}",lineNumber,streamReader.ReadLine());
            }
        }
        Console.WriteLine(@"Line numbers have been inserted in front of each line of the text file.
You can find the ""result.txt"" file in the bin\Debug folder of this project.");
    }
}

