// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace _05._64BitArray
{
    using System;

    public class MainProgram
    {
        static void Main()
        {
            BitArray64 firstTestArr = new BitArray64(3);
            Console.WriteLine(firstTestArr);
            Console.WriteLine(firstTestArr.GetHashCode());

            BitArray64 secondTestArr = new BitArray64(3);
            Console.WriteLine(secondTestArr);
            Console.WriteLine(secondTestArr.GetHashCode());

            Console.WriteLine(firstTestArr.Equals(secondTestArr));
            Console.WriteLine(firstTestArr != secondTestArr);
        }
    }
}
