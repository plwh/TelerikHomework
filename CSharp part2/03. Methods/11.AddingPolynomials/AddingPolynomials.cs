// Write a method that adds two polynomials.Represent them as arrays of their coefficients.

using System;

class AddingPolynomials
{
    static void PrintPolynomial(int[] array)
    {
        for (int j = array.Length - 1; j >= 0; j--)
        {
            if (j == array.Length - 1 && array[j] != 0)
            {
                Console.Write("{0}{1}x^{2} ", array[j] > 0 ? "" : "-", Math.Abs(array[j]), j);
            }
            else if (j == 0)
            {
                if (array[j] < 0) Console.Write("{0}{1} ", "- ", -array[j]);
                else if (array[j] > 0) Console.Write("{0}{1} ", "+ ", array[j]);
            }
            else
            {
                if (array[j] < 0) Console.Write("{0}{1}x^{2} ", "- ", -array[j], j);
                else if (array[j] > 0) Console.Write("{0}{1}x^{2} ", "+ ", array[j], j);
            }
        }
        Console.WriteLine();
    }
    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {       
        int maxLength = firstPolynomial.Length > secondPolynomial.Length? firstPolynomial.Length:secondPolynomial.Length;
        int [] result = new int[maxLength];
        if (secondPolynomial.Length < firstPolynomial.Length)
        {
            for (int i = 0; i < secondPolynomial.Length; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }
            for (int j = secondPolynomial.Length; j < firstPolynomial.Length;j++)
                result[j] = firstPolynomial[j];
        }
        else if (secondPolynomial.Length > firstPolynomial.Length)
        {
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                result[i] = secondPolynomial[i] + firstPolynomial[i];
            }
            for (int j = firstPolynomial.Length; j < secondPolynomial.Length; j++)
                result[j] = secondPolynomial[j];
        }
        else
        {
            for (int i = 0; i < firstPolynomial.Length ; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter your polynomial degree:");
        int firstDegree = int.Parse(Console.ReadLine());
        int[] firstPolynomial = new int[firstDegree+1];
        for (int i = firstDegree; i >= 0; i--)
        {
            Console.Write("x^{0}:", i);
            firstPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Polynomial in normal form:");
        PrintPolynomial(firstPolynomial);
        Console.Write("Enter your polynomial degree:");
        int secondDegree = int.Parse(Console.ReadLine());
        int[] secondPolynomial = new int[secondDegree+1];
        for (int i = secondDegree; i >= 0; i--)
        {
            Console.Write("x^{0}:", i);
            secondPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Polynomial in normal form:");
        PrintPolynomial(secondPolynomial);
        int[] result = AddPolynomials(firstPolynomial, secondPolynomial);
        Console.Write("Result of polynomial addition:");
        PrintPolynomial(result);
    }
}

