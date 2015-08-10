// Write a method that counts how many times given number appears in given array. Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static string CountAppearance(int[]array, int element)
    {
        int counter = 0;
        string result = "";
        foreach (int number in array)
        {
            if (number == element)
            {
                counter++;
            }
        }
        if (counter == 0)
        {
            result = "There is no such element";
        }
        else 
        {
            result = "Element "+element+" has appearance count = "+counter.ToString();
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("We are given array with elements");
        int[] array = { 5, 10, 15, 20, 5, 10, 15, 5, 30 };
        foreach (int number in array)
        {
            Console.Write(number + ", ");
        }
        Console.Write("\nEnter an element from the array above:");
        int element = int.Parse(Console.ReadLine());
        Console.WriteLine(CountAppearance(array,element));
    }
}

