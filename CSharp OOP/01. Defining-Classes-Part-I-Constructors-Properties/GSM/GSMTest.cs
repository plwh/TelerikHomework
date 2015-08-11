using System;
using System.Collections.Generic;

namespace DefiningClassesPart1
{
    // Problem 7
    public class GSMTest
    {     
        public static void GSMTestClass()
        { 
            GSM firstPhone = new GSM("Galaxy S4","Samsung",1000,"Pesho",new Battery("Standard", 370,17,BatteryTypes.LiIon),new Display(5,16000000),new List<Call>());
            GSM secondPhone = new GSM("Redmi 1S", "Xiaomi", 300, "Gosho", new Battery("BM41"), new Display(4.7, 16000000), new List<Call>());
            GSM thirdPhone = new GSM("Moto G", "Motorola", 400, "John", new Battery("Unknown", 336, 24, BatteryTypes.LiIon), new Display(4.5, 16000000), new List<Call>());
   
            GSM[] phones = new GSM[]{firstPhone,secondPhone,thirdPhone};

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine("Information about phone №{0}\n", i + 1);
                Console.WriteLine(phones[i]+"\n");
            }
            Console.WriteLine("Information about IPhone4S\n");
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
