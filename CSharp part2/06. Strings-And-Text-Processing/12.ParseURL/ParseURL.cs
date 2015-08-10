// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the
// [protocol], [server] and [resource] elements.

using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        Console.WriteLine("URL:{0}",url);
        System.Uri uri = new System.Uri(url);
        string host = uri.Host;
        string protocol = uri.Scheme;
        string resource = uri.PathAndQuery;
        Console.WriteLine(@"Information
[protocol] = {0}
[server] = {1}
[resource] = {2}", protocol, host,resource);   
    }
}

