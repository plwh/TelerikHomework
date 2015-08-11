/* Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? var1 = null;
        double? var2 = null;
        Console.WriteLine("Nullable int={0} Nullable double={1}", var1, var2);
        var1 = 30;
        var2 = 256.44;
        Console.WriteLine("Value int={0} Value double={1}", var1, var2);
    }
}

