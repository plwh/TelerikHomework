// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        
        string source = "https://dougseven.files.wordpress.com/2012/02/blog_image-ninja.jpg";
        string localFileName = Path.GetFileName(source);
        using (WebClient webClient = new WebClient())
        {
            try
            {
                Console.WriteLine("Starting download of file from\n{0}", source);
                webClient.DownloadFile(source, localFileName);
                Console.WriteLine(@"File has been downloaded successfully.You can find it in the bin\Debug folder of this project");
            }
            catch (WebException exception)
            {
                Console.Write(exception.Message);
                if (exception.InnerException != null)
                {
                    Console.WriteLine(" " + exception.InnerException.Message);
                }
                else
                {
                    Console.WriteLine();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong. You can read details below:\n{0}", exception.Message);
            }
        }          
    }
}
