// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

namespace _03.Problems_3_5
{
    using System;
    using System.Linq;
    using System.Collections;

    class SortStudents
    { 
        static void Main()
        {
            var studentsArr = new[] {
                new {FirstName = ("John"), LastName = ("Doe"), Age = 30},
                new {FirstName = ("Christian"), LastName = ("Henderson"), Age = 20},
                new {FirstName = ("Ian"), LastName = ("Collins"), Age = 10},
                new {FirstName = ("Norma"), LastName = ("Koontz"), Age = 40},
                new {FirstName = ("Harris"), LastName = ("Potter"), Age = 50},                                              
                                    };
            Console.WriteLine("Students in array:");
            foreach (var student in studentsArr)
            {
                Console.WriteLine("First name: {0}   Last name: {1}   Age: {2}",
                    student.FirstName, student.LastName, student.Age);
            }         
            var results =
                from student in studentsArr
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;
            Console.WriteLine("\nStudents whose first name is before their last name alphabetically:");
            foreach (var result in results)
            {
                Console.WriteLine("First name: {0}   Last name: {1}   Age: {2}",
                    result.FirstName,result.LastName,result.Age);
            }
        }
    }
}
