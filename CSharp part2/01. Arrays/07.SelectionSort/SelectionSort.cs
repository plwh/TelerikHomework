/* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
move it at the second position, etc. */

using System;

class SelectionSort
{
    static void Main()
    {
        int i, j, min, temp;
        int[] array = { 20, 50, 60, 30, 70, 1, 5 };
        Console.Write("Before sort:");
        foreach (int number in array)
        {
            Console.Write(number + ",");
        }
        Console.WriteLine();
	    for (i = 0; i < array.Length - 1; i++)
	    {
	    	min = i;
	    	for (j = i + 1; j < array.Length; j++)
		    {
		    	if (array[j] < array[min])
		    	{
			    	min = j;
			    }
		    }
		    temp = array[i];
		    array[i] = array[min];
		    array[min] = temp;
	    }
        Console.Write("After selection sort:");
        foreach (int number in array)
        {
            Console.Write(number+",");
        }
        Console.WriteLine();
    }
}
    

