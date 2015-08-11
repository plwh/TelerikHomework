// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace _04.AgeRange
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class AgeOfStudents
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
                where student.Age >= 18 && student.Age <= 24
                select student;
            Console.WriteLine("\nStudents with age between 18 and 24:");
            foreach (var result in results)
            {
                Console.WriteLine("First name: {0}   Last name: {1}   Age: {2}",
                    result.FirstName, result.LastName, result.Age);
            }
        }
    }
}
