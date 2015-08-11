/* Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
 in given integer number n, has value of 1. */

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter p:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool isOne = (bit == 1);
        Console.WriteLine("Bit at position p equals to 1? {0}", isOne);
    }
}

