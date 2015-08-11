// Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        int j = 2 * n;
        int l = n + 1;
        BigInteger nFactorial = 1;
        BigInteger nBy2Factorial = 1;
        BigInteger nPlus1Factorial = 1;
        if (n >= 0 && n <= 100)
        {
            if (n == 0)
            {
                Console.WriteLine("Catalan(n):" + (n+1));
                return;
            }
            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                nFactorial *= n;
                n--;
            }
            while (true)
            {
                if (j == 1)
                {
                    break;
                }
                nBy2Factorial *= j;         
                j--;
         
            }
            while(true)
            {
                if (l == 1)
                {
                    break;
                }
                nPlus1Factorial *= l;
                l--;
            }
        }
        else
        {
            Console.WriteLine("n must be in range: (0 <= n <= 100)");
            return;          
        }
        BigInteger catalanNumber = nBy2Factorial/(nPlus1Factorial*nFactorial);
        Console.WriteLine("Catalan(n) = {0}", catalanNumber);
    }

}

