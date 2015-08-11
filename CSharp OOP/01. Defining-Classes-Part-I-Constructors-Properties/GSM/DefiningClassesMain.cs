// Execution of program starts here.

using System;

namespace DefiningClassesPart1
{
    class DefiningClassesMain
    {
        static void Main()
        {
            GSMTest.GSMTestClass(); // Problem 7
            // Problem 12
            GSMCallHistoryTest.GenerateCallHistory();
            GSMCallHistoryTest.DisplayCallsInfo();
            GSMCallHistoryTest.CalculateTotalCallPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine("\nPrice after longest call is removed:");
            GSMCallHistoryTest.CalculateTotalCallPrice();
            GSMCallHistoryTest.phone.ClearCallHistory();
            Console.WriteLine("\nCall history is cleared.");
            GSMCallHistoryTest.DisplayCallsInfo();
        }
    }
}
