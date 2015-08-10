// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static bool isHoliday(DateTime date)
    {
        bool result = false;
        DateTime[] holidays = new DateTime[]
        {
            new DateTime(2015, 3, 3),
            new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 10, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31)
        };
        foreach (var holiday in holidays)
        {
            if (date.Year == holiday.Year && date.Month == holiday.Month && date.Day == holiday.Day)
            return true;
        }
        return result;
    }
    static int CalcWorkdays(DateTime startDate, DateTime endDate)
    {      
        int count = 0; // workday counter
        for (startDate = DateTime.Now.Date; startDate <= endDate; startDate = startDate.AddDays(1))
        {
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && isHoliday(startDate) == false)
            {
                count++;
            }
            else
            {
                continue;
            }
        }
        return count;
    }
    static void Main()
    {

        DateTime startDate = DateTime.Now.Date;
        Console.Write("Enter a date in format dd/mm/yyyy:");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        if (endDate < startDate)
        {
            Console.WriteLine("Date entered should be after today's date.");
            return;
        }
        else
        { 
            Console.WriteLine("Working days from {0} to {1}:{2}", startDate.ToString("d"), endDate.ToString("d"), CalcWorkdays(startDate, endDate));
        }    
    }
}

