using System;
using System.Linq;

namespace DefiningClassesPart1
{ 
    // Problem 12 
    public class GSMCallHistoryTest
    {   
        public static GSM phone = new GSM("6630", "Nokia");

        public static Call[] testCalls = 
        {
            new Call(DateTime.Parse("04/02/2015 12:16:50"), "0888888888", 10),              
            new Call(DateTime.Parse("06/05/2015 16:12:05"), "0878888888", 60),         
            new Call(DateTime.Parse("03/09/2015 18:30:20"), "0898888888", 120)       
        };
      
        public static void GenerateCallHistory()
        {
            for (int j = 0; j < testCalls.Length; j++)
            {
                phone.AddCall(testCalls[j]);
            } 
        }

        public static void DisplayCallsInfo()
        {
            Console.WriteLine("\nCall history:");
            for (int i = 0; i < phone.CallHistory.Count;i++)
            {
                Console.WriteLine(" Called number: {0} Date and time: {1} Duration: {2} sec", 
                                   phone.CallHistory[i].DialedPhoneNumber, phone.CallHistory[i].Date, phone.CallHistory[i].Duration);
            }
        }
        public static void CalculateTotalCallPrice()
        {
            decimal price = phone.CalculateTotalPrice(0.37M); 
            Console.WriteLine("Total call price: {0:F2} lv", price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = phone.CallHistory.OrderBy(x => x.Duration).ToArray()[phone.CallHistory.Count - 1];
            phone.RemoveCall(longestCall);
        }
    }
}
