// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;
using LargerThanNeighbours;

class FirstLargerThanNeighbours
{
    static void Main()
    {
         Console.WriteLine("We are given array with elements");
        int[] array = { 4, 12, 33, 19, 4, 9, 44, 29 };
        foreach (int number in array)
        {
            Console.Write(number + ", ");
        }
        Console.WriteLine();
        for(int i=0;i<array.Length;i++)
        {
            if (BiggerThanNeighbours.CompareNeighbours(array, i))
            {
                Console.WriteLine("Element {0} is the 1s element larger than its neighbours. It has index = {1}",array[i],i);
                break;
            }
        }       
    }
}

