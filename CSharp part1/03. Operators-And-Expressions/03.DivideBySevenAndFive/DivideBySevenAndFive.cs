//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBySevenAndFive
{
    static void Main()
    {
       Console.Write("Please enter a number:");
       int number = int.Parse(Console.ReadLine());
       bool result = true;
       if (number == 0)
       {
           result = false;
       }
       else if ((number % 7 == 0) && (number % 5 == 0))
       {
           result = true;
       }
       else
       {
           result = false;
       }  
       Console.WriteLine("Divides by 7 and 5? {0}", result);       
    }
}
