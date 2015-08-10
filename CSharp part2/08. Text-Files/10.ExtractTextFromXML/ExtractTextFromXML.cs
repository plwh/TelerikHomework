// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Xml;

class ExtractTextFromXML
{
    private static void RemoveXMLTags(string input)
    {
        int openedTags = 0;
        StringBuilder buffer = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            int nextChar = input[i];
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
        string textOnly = regexWhitespace.Replace(trimmed, "\n");
        if (!string.IsNullOrEmpty(textOnly))
        {
            Console.WriteLine(textOnly);
        }
    }
    static void Main()
    {
        XmlDocument document = new XmlDocument();
        document.Load(@"test.xml");
        string xmlString = document.OuterXml;
        Console.WriteLine("We are given XML file \"text.xml\"");
        Console.WriteLine("Contets of file with XML tags removed:");
        RemoveXMLTags(xmlString);
    }
}

