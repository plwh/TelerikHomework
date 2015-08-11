// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same
// functionality as Substring in the class String.

namespace _01.StringBuilder.Substring
{
    using System;
    using System.Text;

    class StringBuilderSubstring
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("Hello, C#!");
            Console.WriteLine("We are given string:{0}", test);
            StringBuilder testResult = test.Substring(7);
            Console.WriteLine("Substring starting from character at positon 7:"+testResult);
            testResult = test.Substring(0, 5);
            Console.WriteLine("Substring starting at position zero that has length 5 characters:"+testResult);
        }
    }

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder builder, int index)
        {
            if (builder.Length <= index)
            {
                throw new ArgumentOutOfRangeException("Index can't be greater than length of input string.");
            }
            return new StringBuilder(builder.ToString().Substring(index));
        }

        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            if(builder.Length < index + length)
            {
                throw new ArgumentOutOfRangeException("Substring length exceeds number of characters in StringBuilder after the start index.");
            }

            if (builder.Length < 0 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index or length is less than zero.");
            }           
            return new StringBuilder(builder.ToString().Substring(index, length));
        }
    }
}
