// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter min:");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter max:");
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();
        if (min != max && min < max)
        {         
            Console.Write("random numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" "+r.Next(min, max+1));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }       
    }
}

