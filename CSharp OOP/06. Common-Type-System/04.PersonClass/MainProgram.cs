// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the
// information of a person and if age is not specified – to say so. Write a program to test this functionality.

namespace _04.PersonClass
{
    using System;

    public class MainProgram
    {
        static void Main()
        {
            Person firstPerson = new Person("Gosho");
            Console.WriteLine(firstPerson);
            Person secondPerson = new Person("Pesho", 26);
            Console.WriteLine(secondPerson);
        }
    }
}
