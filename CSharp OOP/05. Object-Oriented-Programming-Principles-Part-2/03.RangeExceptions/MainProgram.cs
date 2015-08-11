/* Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and 
 * a range definition [start … end].Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by
 * entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013]. */

namespace _03.RangeExceptions
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Number should be in the range [1..100]", 1, 100);
                }
                Console.WriteLine("Enter a date in format (dd.mm.yyyy):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                DateTime startDate = new DateTime(1980, 1, 1);
                DateTime endDate = new DateTime(2013, 12, 31);
                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Date should be in the range [1.1.1980 - 31.12.2013]", startDate, endDate);
                }
            }
            catch (InvalidRangeException<int> ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
