// Describe the strings in C#.
// What is typical for the string data type?
// Describe the most important methods of the String class.

using System;

class StringsInCSharp
{
    static void Main()
    {
        Console.WriteLine(@" Describe the strings in C#.
A string is a sequence of characters stored in a certain address in memory.
Remember the type char? In the variable of type char we can record only one 
character. Where it is necessary to process more than one character then strings come to our aid.

 What is typical for the string data type?
System.String is reference type.
String objects are like arrays of characters (char[])
- They have fixed length (String.Length)
- Elements can be accessed directly by index (index is in range [0..Length-1])

 Describe the most important methods of the String class.
Most important string processing members are:
- Length, this[], Compare(str1, str2), IndexOf(str), LastIndexOf(str), Substring(startIndex, length), Replace(oldStr, newStr), Remove(startIndex, length),
ToLower(), ToUpper()
                        ");
    }
}
