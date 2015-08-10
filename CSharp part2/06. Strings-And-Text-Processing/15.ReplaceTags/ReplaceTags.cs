// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        Console.WriteLine("We are given text:\n\n{0}\n\n", text);
        String result = Regex.Replace(text,@"<a href=""","[URL=");
        result = Regex.Replace(result,@""">","]");
        result = Regex.Replace(result,@"</a>","[/URL]");
        Console.WriteLine("Tags tags <a href=\"...\">...</a> replaced with [URL=...].../URL]:\n\n{0}\n",result);
    }
}

