// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubstring
{
    static void Main()
    {
        string text = File.ReadAllText("../../text.txt");
        text = text.Replace("start", "finish");
        File.WriteAllText("../../output.txt", text);
        Console.WriteLine(@"We are given file ""text.txt""(located in the main folder of this project)
All occurences in file of substring ""start"" have been replaced with ""finish"".
Output (output.txt) can be found in the main folder of this project.");
    }
}

