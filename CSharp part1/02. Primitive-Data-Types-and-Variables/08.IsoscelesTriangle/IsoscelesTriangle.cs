/* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © © */

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        // Also while running change console font to "Lucida Console"
        char a = '\u00A9';
        Console.WriteLine(@"
               {0}


              {0} {0}


             {0}   {0}


            {0} {0} {0} {0}",a);
    

    }
}