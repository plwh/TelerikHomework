// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static string ToBinary(short input)
    { 
        int length = int.MaxValue;
        string result = "";
        for (int i = 0; i < length; i++)
        {
            result = result + (input % 2).ToString();
            input = (short)(input / 2);
            if (input == 0)
            {
                break;
            }
        }
        char[] reversal = result.ToCharArray();
        Array.Reverse(reversal);
        result = new string(reversal);
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter a number from –32768 to 32767:");
        short number = short.Parse(Console.ReadLine());
        string binRepresentation = "";
        if (number < 0)
            binRepresentation = "1" + ToBinary((short)(32768 + number)).PadLeft(15, '0');
        else
            binRepresentation = ToBinary(number).PadLeft(16, '0');      
        Console.WriteLine("Binary representation:{0}", binRepresentation);
    }
}

