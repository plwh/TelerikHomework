/* In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!) For example, there are 2598960
ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) 
for given n and k (1 < k < n < 100). Try to use only two loops. */

using System;
using System.Numerics;

class NumberOfCombinations
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;
        int j = n - k;
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
                if(j > 0)
                {
                    nMinusKFactorial *= j;
                }
                n--;
                k--;
                j--;
            }
        }
        else 
        {
            Console.WriteLine("n and k must be in range: (1 < k < n < 100)");
            return;
        }
        BigInteger result = nFactorial / (kFactorial * nMinusKFactorial);
        Console.WriteLine("n!/(k!*(n-k)!) = {0}",result);
    }
}

