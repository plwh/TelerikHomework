/* Write a program that can solve these tasks:
- Reverses the digits of a number
- Calculates the average of a sequence of integers
- Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
- The decimal number should be non-negative
- The sequence should not be empty
- a should not be equal to 0 */

using System;

class SolveTasks
{
    static string ReverseDigits(string number)
    {
        if (decimal.Parse(number) < 0)
        {
            return "Number cannot be negative.";
        }
        char[] numberReversal = new char[number.Length];
        for (int i = 0, k = number.Length - 1; k >= 0; i++, k--)
        {
            numberReversal[i] = number[k];
        }
        string reversedNumber = "";
        foreach (char element in numberReversal)
        {
            reversedNumber += element;
        }
        return "Digits of number reversed:"+reversedNumber;
    }
    static decimal CalculateAverage(string sequence)
    {
        string []numbers = sequence.Split(',');       
        decimal averageOfNumbers = 0;
        decimal sum = 0;
        int count = 0;
        foreach(string number in numbers)
        {
            sum += int.Parse(number);
            count++;
        }
        averageOfNumbers = sum / count;
        return averageOfNumbers;
    }
    static decimal SolveLinearEquation(decimal a, decimal b)
    {
        return (b / a) * (-1);
    }
    static void Main()
    {
        Console.Write(@"This program can solve these tasks: 
1) Reverse the digits of a number
2) Calculate the average of a sequence of integers
3) Solve a linear equation a * x + b = 0"+"\n");
        Console.Write("Enter task number:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: 
                Console.Write("Enter a number:");
                string number = Console.ReadLine();
                string result = ReverseDigits(number);
                Console.WriteLine(result);
                break;
            case 2:
                Console.Write("Enter a sequence of integers(separated by \",\"):");
                string sequence = Console.ReadLine();
                if (sequence == "")
                {
                    Console.WriteLine("Sequence shouldn't be empty");
                    break;
                }
                Console.WriteLine("Average of sequence:{0}", CalculateAverage(sequence));
                break;
            case 3:
                Console.Write("Enter a:");
                decimal a = decimal.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a cannot be equal to zero");
                    break;
                }
                else
                { 
                    Console.Write("Enter b:");
                    decimal b = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("x = {0}", SolveLinearEquation(a, b));
                }
                break;
            default:
                Console.WriteLine("Invalid task number!");
                break;
        }
    }
}

