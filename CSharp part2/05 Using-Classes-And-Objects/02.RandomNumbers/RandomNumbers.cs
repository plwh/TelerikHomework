// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        Random rand = new Random();
        Console.WriteLine("Ten random numbers in range [100, 200]:");
        for (int number = 1; number <= 10; number++)
        {
            int randomNumber = rand.Next(100,200);
            Console.Write("{0} ", randomNumber);
            if (number == 10)
            {
                Console.WriteLine();
            }
        }
    }
}

