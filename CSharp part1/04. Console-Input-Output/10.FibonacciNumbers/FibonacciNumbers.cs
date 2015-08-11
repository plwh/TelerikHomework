/* Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. */

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        int[] fibonacci = new int[number]; // инициализиране на масив с дължина равна на номера, който сме въвели
        for (int j = 0; j < fibonacci.Length; j++) 
        {
            if (j < 2)     
            {
                fibonacci[j] = j; // въвеждане на първите две стойности
            }
            else
            {
                fibonacci[j] = fibonacci[j - 1] + fibonacci[j - 2];  /* въвеждане на останалите стойности, всяка следваща
                                                                        стойност е равна на сбора на предишните две */
            }
        }
        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.Write(" {0},", fibonacci[i]); // извеждане на стойностите на масива
        }
        Console.WriteLine();
    }
}

