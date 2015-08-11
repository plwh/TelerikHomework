/* Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0. */

using System;

class ExtractBitThree
{
    static void Main()
    {
        Console.Write("Please enter n:");
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint nAndMask = n & mask;
        uint bit = nAndMask >> 3;
        Console.WriteLine("Bit #3 is "+bit);

    }
}