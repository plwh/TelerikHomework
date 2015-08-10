// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        Console.Write("Enter full path of first text file on your computer:\n");
        string firstInput = Console.ReadLine();
        StreamReader firstReader = new StreamReader(firstInput);
        string firstText = firstReader.ReadToEnd();
        Console.Write("Enter full path of second text file on your computer:\n");
        string secondInput = Console.ReadLine();
        StreamReader secondReader = new StreamReader(secondInput);
        string secondText = secondReader.ReadToEnd();
        StreamWriter streamWriter = new StreamWriter("result.txt");
        using (streamWriter)
        {
            Console.WriteLine(@"The contents of the two text files have been concatenated.
You can find the ""result.txt"" file in the bin\Debug folder of this project.");
            streamWriter.WriteLine(firstText+secondText);
        }
    }
}
