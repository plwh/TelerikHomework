/* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below. */

using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer number:");
        int n = int.Parse(Console.ReadLine());
        int min=0, max=0;
        double sum = 0, avg = 0;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("number {0}:", i+1);
            numbers[i]= int.Parse(Console.ReadLine());
            sum += numbers[i];
            avg = sum / n;
            min = numbers[0];
            if(numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
       
   
            Console.WriteLine("min = {0} max = {1} sum = {2} avg = {3:F2}", min, max, sum, avg);
    }    
}
