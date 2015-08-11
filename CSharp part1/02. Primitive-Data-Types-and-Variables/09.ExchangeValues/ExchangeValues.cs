/* Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange. */

using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Value before exchange \na={0} b={1}", a, b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Value after exchange \na={0} b={1}", a, b);
    }
}
