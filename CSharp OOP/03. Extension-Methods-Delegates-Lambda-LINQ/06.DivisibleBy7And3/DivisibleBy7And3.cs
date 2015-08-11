// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.DivisibleBy7And3
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 , 21};
            // using extension methods
            // var results = numbers.Where(x => (x % 21) == 0);
            Console.WriteLine("Items in array:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //using LINQ
            var results =
                from number in numbers
                where number % 21 == 0
                select number;
            Console.WriteLine("Array elements divisible by 7 and 3:");
            foreach(var result in results)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }
    }
}
