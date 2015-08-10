// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine(@"Enter full path of text file on your computer.(e.g. c:\windows\win.ini)");
        string input = Console.ReadLine();
        try
        {
            string text = System.IO.File.ReadAllText(input);
            Console.Write("Contents of file:\n{0}", text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input is not existing path. Please try again.");
            Main();
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path name is not legal.Please try again.");
            Main();
        }
        catch (IOException)
        {
            Console.WriteLine("File can't be opened because it is being used by another application. Close the application and try again.");
            Main();
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is problem with your access rights.");
            Console.WriteLine("This problem occurs if you enter a path, without file (.txt). Please try again.");
            Main();
        }
    }
}
