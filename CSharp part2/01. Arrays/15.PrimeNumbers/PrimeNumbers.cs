// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
// RUN AT YOUR OWN RISK!!!
 
using System;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        bool[] array = new bool[10000000];
        for ( long a = 2; a < array.Length; a++)
        {
            array[a] = true;   
        }
        for ( long i = 2; i < array.Length; i++)
        {
            if (array[i] == true)
            {
                for (long j = (long)Math.Pow(i, 2), counter = 1; j < array.Length; j = (long)Math.Pow(i, 2) + i * counter, counter++)
                { 
                    array[j] = false;          
                }
            }
        }
        Console.WriteLine("Prime numbers in range [1...10 000 000], using Sieve of Eratosthenes algorithm\n");
        for (long index = 0; index < array.Length; index++)
        {
            if (array[index] == true)
            {
                Console.Write(index + " ");
            }
        }
        Console.WriteLine();
    }
}

