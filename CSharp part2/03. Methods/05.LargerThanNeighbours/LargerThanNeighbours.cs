// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

namespace LargerThanNeighbours
{
    public class BiggerThanNeighbours
    {
        public static bool CompareNeighbours(int[] arr, int position)
        {
            bool isLarger = false;
            if (position < arr.Length && position > 0)
            {
                if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
                {
                    isLarger = true;
                }
            }
            return isLarger;
        }
        static void Main()
        {
            Console.WriteLine("We are given array with elements");
            int[] array = { 5, 13, 34, 20, 5, 10, 45, 30 };
            foreach (int number in array)
            {
                Console.Write(number + ", ");
            }
            Console.Write("\nEnter position:");
            int position = int.Parse(Console.ReadLine());
            if (position == array.Length - 1 || position == 0)
            {
                Console.WriteLine("Element at position {0} doesn't have two neighbours", position);
                return;
            }
            else if (CompareNeighbours(array, position))
            {
                Console.WriteLine("Element at position {0} is larger than neighbours {1} and {2}", position, array[position - 1], array[position + 1]);
            }
            else
            {
                Console.WriteLine("Element at position {0} is not larger than its neighbours", position);
            }
        }
    }
}
