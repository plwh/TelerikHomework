// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in 
// descending order. Rewrite the same with LINQ.

namespace _05.OrderStudents
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class OrderOfStudents
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
            // using extension methods
            // var results = studentsArr.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            // using LINQ 
            var results = 
                from student in studentsArr
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine("\nStudents sorted by first name and last name in descending order:");
            foreach (var result in results)
            {
                Console.WriteLine("First name: {0}   Last name: {1}   Age: {2}",
                    result.FirstName, result.LastName, result.Age);
            }
        }
    }
}
