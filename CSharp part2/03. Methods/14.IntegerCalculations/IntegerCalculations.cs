// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

class IntegerCalculations
{
    static long GetMin(params int[] elements)
    {
        long min = elements[0];
        foreach (int element in elements)
        {
            if(element < min)
            {
                min = element;
            }
        }
        return min;
    }
    static long GetMax(params int[] elements)
    {
        long max = elements[0];
        foreach (int element in elements)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }
    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (int element in elements)
            sum += element;
        return sum;
    }
    static decimal CalculateAverage(params int[] elements)
    {
        decimal averageOfNumbers = 0;
        decimal sum = CalcSum(elements);
        averageOfNumbers = sum / elements.Length;
        return averageOfNumbers;
    }
    static long CalcProduct(params int[] elements)
    {
        long product = 1;
        foreach (int element in elements)
            product *= element;
        return product;
    }
    static void Main()
    {
        Console.WriteLine("We are given set of integers: 1,3,5,7,9,12");
        Console.WriteLine("Min:{0}", GetMin(1, 3, 5, 7, 9, 12));
        Console.WriteLine("Max:{0}", GetMax(1, 3, 5, 7, 9, 12));
        Console.WriteLine("Average:{0}", CalculateAverage(1, 3, 5, 7, 9, 12));
        Console.WriteLine("Sum:{0}", CalcSum(1, 3, 5, 7, 9, 12));
        Console.WriteLine("Product:{0}", CalcProduct(1, 3, 5, 7, 9, 12));    
    }
}

