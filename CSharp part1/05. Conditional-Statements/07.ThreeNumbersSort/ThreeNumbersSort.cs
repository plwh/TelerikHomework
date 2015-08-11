// Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements.

using System;

class ThreeNumbersSort
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        double temp = 0;
        if (a >= b)
        {
            if (c > a)
            {
                temp = c;
                c = a;
                a = temp;
                if (c > b)
                {
                    temp = b;
                    b = c;
                    c = temp;
                }
            }
            else if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
        }
        else 
        {
            temp = a;
            a = b;
            b = temp;
            if (c > a)
            {
                temp = c;
                c = a;
                a = temp;
                if (c > b)
                {
                    temp = b;
                    b = c;
                    c = temp;
                }
            }
            else if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
        }
        Console.WriteLine("Numbers sorted: {0} {1} {2}",a,b,c);
    }
}

