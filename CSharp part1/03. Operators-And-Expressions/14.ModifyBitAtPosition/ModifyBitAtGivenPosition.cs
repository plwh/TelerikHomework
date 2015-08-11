/* We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
at the position p from the binary representation of n while preserving all other bits in n. */

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter p:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter v:");
        int v = int.Parse(Console.ReadLine());
        if (!(v == 1) && !(v == 0))
        {
            Console.WriteLine("v must be 0 or 1");
            return;
        }
        else if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("n:{0} p:{1} v:{2} result:{3}",n,p,v,result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("n:{0} p:{1} v:{2} result:{3}", n, p, v, result);
        }
    }
}

