//Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace _17.LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            string[] arrayOfStrings = { "This is the longest string","Hello, CSharp!","Second longest string","Short string"};
            var longestString = arrayOfStrings.OrderByDescending(s => s.Length).First();
            Console.WriteLine("We have string array with elements:");
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine("arr[{0}]:{1}", i, arrayOfStrings[i]);
            }
            Console.WriteLine("\nLongest string:\n{0}", longestString);
        }
    }
}
