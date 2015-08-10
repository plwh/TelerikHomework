// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static string SortByLength(string[]arr)
    {
        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        string str = "";
        foreach(string element in arr)
        {
            str += element + " ";
        }  
        return str;
    }
    static void Main()
    {
        string[] array = { "abc", "defg","a", "be", "jklmn","cde"};
        Console.WriteLine("String array elements:");
        foreach (string element in array)
        {
            Console.Write(element+" ");
        }
        Console.WriteLine("\nArray sorted by the length of its elements:\n{0}",SortByLength(array));
    } 
}

