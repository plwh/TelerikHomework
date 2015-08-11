using System;

namespace _05.GenericList
{
    class GenericList_Main
    {
        static void Main()
        { 
            GenericList<int> testList = new GenericList<int>(4);
            testList.AddElement(10);
            testList.AddElement(15);
            testList.AddElement(50);
            testList.AddElement(30);
            Console.WriteLine("Initial list contents:\n"+testList);
            testList.RemoveAt(1);
            Console.WriteLine("Minimal element: {0} Maximal element: {1}\n",testList.Min(),testList.Max());
            Console.WriteLine("List contents after element at index 1 is removed:\n" + testList);
            testList.InsertAt(20, 1);
            Console.WriteLine("List contents after inserting 20 at index 1:\n" + testList);
            int indexOfElement = testList.FindElement(50);
            Console.WriteLine("Index of element with value equal to 50 ---> " + indexOfElement+"\n");
            Console.WriteLine("Capacity before adding element to overfill internal array:" + testList.Capacity+"\n");
            testList.AddElement(40);
            Console.WriteLine("Capacity after adding element(auto-grow functionality is tested here):" + testList.Capacity + "\n");
            testList.Clear();
            Console.WriteLine("List contents after list is cleared:");
        }
    }
}
