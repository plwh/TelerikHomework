// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time
// after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Text;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter date in format day.month.year hour:minute:second");
        DateTime date = DateTime.Parse(Console.ReadLine());
        string day = "";
        DateTime dateAfter = date;
        dateAfter = dateAfter.AddHours(6);
        dateAfter = dateAfter.AddMinutes(30);
        switch (dateAfter.DayOfWeek.ToString())
        {
            case "Monday": day += "Понеделник"; break;
            case "Tuesday": day += "Вторник"; break;
            case "Wednesday": day += "Сряда"; break;
            case "Thursday": day += "Четвъртък"; break;
            case "Friday": day += "Петък"; break;
            case "Saturday": day += "Събота"; break;
            case "Sunday": day += "Неделя"; break;
        } 
        Console.WriteLine("Date and time after 6 hours and 30 minutes\n{0}",dateAfter);
        Console.WriteLine("Day of the week:{0}",day);
    }
}

