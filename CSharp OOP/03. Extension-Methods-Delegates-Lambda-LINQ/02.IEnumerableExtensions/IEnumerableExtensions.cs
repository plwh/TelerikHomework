// Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
// sum, product, min, max, average.

namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IEnumerableExtensions
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5 };
            Console.WriteLine("Elements in collection:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum:" + numbers.Sum());
            Console.WriteLine("Product:" + numbers.Product());
            Console.WriteLine("Min:" + numbers.Min());
            Console.WriteLine("Max:" + numbers.Max());
            Console.WriteLine("Average:" + numbers.Avg());
        }
    }

    public static class Extensions
    { 
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            decimal sum = 0;
            foreach (var number in collection)
            {
                sum += Convert.ToDecimal(number);
            }
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal product = 1;
            foreach (var number in collection)
            {
                product *= Convert.ToDecimal(number);
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T minElement = collection.ElementAt(0);
            foreach (var number in collection)
            {
                if (number.CompareTo(minElement) < 0)
                {
                    minElement = number;
                }
            }
            return minElement;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T maxElement = collection.ElementAt(0);
            foreach (var number in collection)
            {
                if (number.CompareTo(maxElement) > 0)
                {
                    maxElement = number;
                }
            }
            return maxElement;
        }
        public static decimal Avg<T>(this IEnumerable<T> collection)
        {
            return collection.Sum<T>() / collection.Count<T>();
        }
    }
}
