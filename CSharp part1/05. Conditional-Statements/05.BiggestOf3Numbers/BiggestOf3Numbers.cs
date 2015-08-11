// Write a program that finds the biggest of three numbers.

using System;

class BiggestOf3Numbers
{
        static void Main()
        {
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            double c = double.Parse(Console.ReadLine());
            double biggest = 0;
            if (a >= b)
            {
                biggest = a;
                if (a < c)
                {
                    biggest = c;
                }
            }
            else if (a < b)
            { 
                biggest = b;
                if (c > b)
                {
                    biggest = c;
                }
            }   
            Console.WriteLine("Biggest of three numbers:"+biggest);
        }
}

