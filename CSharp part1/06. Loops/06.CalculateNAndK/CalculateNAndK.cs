//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

using System;

class CalculateNAndK
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        var nFactorial = 1;
        var kFactorial = 1;
        if (k > 1 && n > k && n < 100)
        {
            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                nFactorial *= n;
                if (k > 0)
                {
                    kFactorial *= k;
                }
                n--;
                k--;
            }
        }
        else
        {
            Console.WriteLine("n and k must be in range: (1 < k < n < 100)");
            return;
        }
        Console.WriteLine("n!/k! = {0}",nFactorial/kFactorial);
    }
}