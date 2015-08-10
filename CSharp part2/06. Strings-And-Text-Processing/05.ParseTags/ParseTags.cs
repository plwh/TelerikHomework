/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested. */

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ParseTags
{
    static string ExtractString(string s, string tag)
    {
        var startTag = "<" + tag + ">";
        int startIndex = s.IndexOf(startTag) + startTag.Length;
        int endIndex = s.IndexOf("</" + tag + ">", startIndex);
        return s.Substring(startIndex, endIndex - startIndex);
    }
    public static string ScrubHtml(string value)
    {
        var step1 = Regex.Replace(value, @"<[^>]+>|&nbsp;", "").Trim();
        var step2 = Regex.Replace(step1, @"\s{2,}", " ");
        return step2;
    }
    static void Main()
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>";
        Console.WriteLine("We are given text:\n{0}", str);
        string tag = "upcase";
        string stringBetweenTag = ExtractString(str,tag);
        string output = Regex.Replace(str, stringBetweenTag, stringBetweenTag.ToUpper());
        string result = ScrubHtml(output);
        Console.WriteLine("Result:{0}",result);
    }
}
