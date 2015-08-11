/* You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter n integer numbers(separated by a space):");
        string n = Console.ReadLine();
        string[] splitNumbers = n.Split(' ');
        int[] numbers = new int[splitNumbers.Length];
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(splitNumbers[i]);
        }
        int oddProduct = 1;
        int evenProduct = 1;
        for (int j = 0; j < numbers.Length; j+=2)
        {
            oddProduct *= numbers[j];
        }
        for (int k = 1; k < numbers.Length; k+= 2)
        {
            evenProduct *= numbers[k];
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("odd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
        }
    }
}

