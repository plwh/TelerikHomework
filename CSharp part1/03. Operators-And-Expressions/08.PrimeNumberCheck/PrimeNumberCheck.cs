/* Write an expression that checks if given positive integer number n (n = 100) 
   is prime (i.e. it is divisible without remainder only to itself and 1). */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i=2;i<number;i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }                
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Number is prime");
        }
        else
        {
            Console.WriteLine("Number is not prime");
        }          
    }
}
