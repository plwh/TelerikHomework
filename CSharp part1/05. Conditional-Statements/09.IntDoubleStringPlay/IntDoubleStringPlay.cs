/* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement. */

using System;

class IntDoubleStringPlay
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        string input = Console.ReadLine();
        int type;
        if (int.TryParse(input, out type))
        {
                switch (type)
                {
                    case 1:
                        Console.Write("Please enter an integer:");
                        int var1 = int.Parse(Console.ReadLine());
                        var1 += 1;
                        Console.WriteLine(var1);
                        break;
                    case 2:
                        Console.Write("Please enter a double:");
                        double var2 = double.Parse(Console.ReadLine());
                        var2 += 1;
                        Console.WriteLine(var2);
                        break;
                    case 3:
                        Console.Write("Please enter a string:");
                        string var3 = Console.ReadLine();
                        var3 += "*";
                        Console.WriteLine(var3);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }         
        }
        else
        {
            Console.WriteLine("Invalid input"); 
        }
    }
}

