// Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another
// file test.txt.The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in 
// descending order. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            string[] listOfWords = File.ReadAllLines("../../words.txt");
            int[] count = new int[listOfWords.Length];
            using (StreamReader reader = new StreamReader("../../test.txt"))
            {
                int lineNum = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNum++;
                    for (int index = 0; index < listOfWords.Length; index++)
                    {
                        count[index] += ((Regex.Matches(line, @"\b" + listOfWords[index] + @"\b").Count));
                    }
                    line = reader.ReadLine();
                }
            }
            Array.Sort(count, listOfWords);
            using (StreamWriter writer = new StreamWriter("../../result.txt"))
            {
                for (int i = listOfWords.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("Word {0} Occurences {1}", listOfWords[i], count[i]);
                }
                Console.WriteLine(@"The number of times each word in ""words.txt"" exists in ""test.txt"" was found.
Result has been saved in file ""result.txt"". The three files can be found in the main folder of this project.");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is problem with your access rights.");
            Console.WriteLine("This problem occurs if you enter a path, without file (.txt). Please try again.");
            Main();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("There is no such file");
            Main();
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong.Read details below.\n{0}", ex.Message);
        }
    }
}

