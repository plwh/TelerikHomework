// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date:");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second date:");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan diff = firstDate - secondDate;
        int days = Convert.ToInt32(Math.Ceiling(diff.TotalDays));
        Console.WriteLine("Distance: {0} days",Math.Abs(days));
    }
}
