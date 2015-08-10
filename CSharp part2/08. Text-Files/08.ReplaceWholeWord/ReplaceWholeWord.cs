// Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        Console.WriteLine(@"We are given file ""test.txt""(located in the main folder of this project)");
        string text = File.ReadAllText("../../test.txt");
        string pattern = @"\bstart\b";
        text = Regex.Replace(text, pattern,"finish");
        File.WriteAllText("../../result.txt", text);
        Console.WriteLine(@"Every occurence in file of word ""start"" has been replaced with ""finish"".
Result (result.txt) can be found in the main folder of this project.");
    }
}

