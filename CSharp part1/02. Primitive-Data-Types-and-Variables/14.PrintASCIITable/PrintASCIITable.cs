/* Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints
the entire ASCII table of characters on the console (characters from 0 to 255). */

using System;

class PrintASCIITable
{
   
    static void Main()
    {
        Console.WriteLine("Printable characters from the ASCII table:");
        Console.WriteLine("Decimal"+"   "+"ASCII");
        for (int i = 0; i <= 255;i++)
        {
            char a = Convert.ToChar(i);
            if (!char.IsControl(a))
            {
                Console.WriteLine( "  "+ i +"        " + a);
            }
        }

    }
}

