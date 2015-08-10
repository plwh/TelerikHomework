// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter full path of first text file:");
            string firstInput = Console.ReadLine();
            string text = File.ReadAllText(firstInput);
            if (new FileInfo(firstInput).Length == 0)
            {
                Console.WriteLine("File {0} is empty", firstInput);
                Main();
            }
            Console.WriteLine("Enter full path of second text file containg words (each on a single line):");
            string secondInput = Console.ReadLine();
            string[] secondTextLines = File.ReadAllLines(secondInput);
            if (new FileInfo(secondInput).Length == 0)
            {
                Console.WriteLine("File {0} is empty", secondInput);
                return;
            }
            for (int i = 0; i < File.ReadAllLines(firstInput).Length; i++)
            {
                for (int j = 0; j < File.ReadAllLines(secondInput).Length; j++)
                {
                    string pattern = secondTextLines[j];
                    text = Regex.Replace(text, pattern, "");
                }
            }
            Console.WriteLine("All words listed in the second text file have been removed from the first one.\nResult is in the same file.");
            File.WriteAllText(firstInput, text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("There is no such file");
            Main();
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path name cannot be empty");
            Main();
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is problem with your access rights.");
            Console.WriteLine("This problem occurs if you enter a path, without file (.txt). Please try again.");
            Main();
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Given path format is not supported");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong.Read details below.\n{0}", ex.Message);
        }
    }
}
