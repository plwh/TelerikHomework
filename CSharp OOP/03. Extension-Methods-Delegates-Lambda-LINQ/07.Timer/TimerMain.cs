
namespace _07.Timer
{
    using System;
    using System.Diagnostics;

    class TimerMain
    {
        static void Main()
        {
            Timer testTimer = new Timer(2);
            Console.WriteLine("Executing method \"DateNow\" every four seconds:");
            testTimer.ExecuteMethod(DateNow);
        }

        public static void DateNow()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
