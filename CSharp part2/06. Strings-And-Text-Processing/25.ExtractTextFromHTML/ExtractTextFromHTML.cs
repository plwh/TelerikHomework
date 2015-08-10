// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    private static void RemoveHtmlTags(string input)
    { 
        int openedTags = 0;
        StringBuilder buffer = new StringBuilder();
        for(int i=0;i<input.Length;i++)
        {
            int nextChar =input[i];
            if (nextChar == -1)
            {
                break;
            }
            char ch = (char)nextChar;
            if (ch == '<')
            {
                if (openedTags == 0)
                {
                    PrintBuffer(buffer);
                    buffer.Length = 0;
                }
                openedTags++;
            }
            else if (ch == '>')
            {
                openedTags--;
            }
            else
            {             
                if (openedTags == 0)
                {
                    buffer.Append(ch);
                }
            }
        }
    }
    private static void PrintBuffer(StringBuilder buffer)
    {
        Regex regexWhitespace = new Regex("\n\\s+");
        string str = buffer.ToString();
        string trimmed = str.Trim();
        string textOnly = regexWhitespace.Replace(trimmed,"\n");
        if (!string.IsNullOrEmpty(textOnly))
        {
            Console.WriteLine(textOnly);
        }
    }
    static void Main()
    {
        string text = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>
    aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>";
        Console.WriteLine("We are given HTML text:\n\n{0}\n",text);
        Console.WriteLine("Text without HTML tags:");
        RemoveHtmlTags(text);
    }
}

