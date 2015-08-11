// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter d:");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter e:");
        double e = double.Parse(Console.ReadLine());
        double max = 0;
        if (a >= b)
        {
            max = a;
            if (c > a) 
            {
                max = c;
                max = (d > c) ? d : c;
                max = (max > e) ? max : e;
            }
            else
            {
                if (d > a)
                {
                    max = d;
                    max = (max > e) ? max : e;
                }
                else
                {
                    max = (e > a) ? e : a;               
                }
            }
        }
        else
        {
            max = b;
            if (c > b)
            {
                max = c;
                max = (d > c) ? d : c;
                max = (max > e) ? max : e;
            }
            else
            {
                if (d > b)
                {
                    max = d;
                    max = (max > e) ? max : e;
                }
                else
                {
                    max = (e > b)? e : b;
                }
            }
        }
        Console.WriteLine("Biggest of five numbers:" + max); 
    }
}

