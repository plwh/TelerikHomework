// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are
// different. Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("We are given two files \"TextFile1.txt\" and \"TextFile2.txt\"(located in the main \ndirectory of this project)");
        string[] firstTextLines = File.ReadAllLines("../../TextFile1.txt");
        string[] secondTextLines = File.ReadAllLines("../../TextFile2.txt");
        int sameLineCount = 0;
        int diffLineCount = 0;
        for (int line = 0; line < firstTextLines.Length; line++)
        {        
            if (firstTextLines[line].Equals(secondTextLines[line]))
            {
                sameLineCount++;
            }
            else
            {
                diffLineCount++;
            }  
        }
        Console.WriteLine("Number of same lines:{0}", sameLineCount);
        Console.WriteLine("Number of different lines:{0}", diffLineCount);       
    }
}

