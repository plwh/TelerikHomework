//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
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
        Console.WriteLine("Bit at index p is "+bit);
    }
}

