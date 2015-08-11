/* Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by 
hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in
ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name. */

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("John","Newman",6),
                new Student("Paul","Walker",3),
                new Student("Tom","Jones",5),
                new Student("Terry","Jacobs",2),
                new Student("Ashton","Martin",6),
                new Student("Bear","Gill",5),
                new Student("Shawn","Gibson",4),
                new Student("Mike","Paxton",3),
                new Student("Billy","Mays",2),
                new Student("Usain","Colt",6)
            };
            Console.WriteLine("Information about students in list:");
            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\nStudents sorted by grade(ascending):");
            var sortedStudents =
                from student in listOfStudents
                orderby student.Grade ascending
                select student;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker("Jonh","Doe",300.0m,8),
                new Worker("Peter","Parker",400.0m,7),
                new Worker("Tony","Martin",500.0m,6),
                new Worker("Terry","Jones",300.0m,5),
                new Worker("Andrew","Jackson",1500.0m,9),
                new Worker("Bill","Gatsby",300.0m,10),
                new Worker("Stan","Winston",700.0m,12),
                new Worker("Michael","Draxler",400.0m,3),
                new Worker("Barry","Hayes",800.0m,4),
                new Worker("Kurt","Reynolds",1200.0m,6)
            };
            Console.WriteLine("\nInformation about workers in list:");
            foreach (var worker in listOfWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine("\nWorkers sorted by earned money per hour(descending):");
            var sortedWorkers = listOfWorkers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var sorted in sortedWorkers)
            {
                Console.WriteLine(sorted);
            }

            var mergedList = listOfStudents
                .Concat<Human>(listOfWorkers)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);
            Console.WriteLine("\nList of students and workers merged and sorted by first and last name:");
            foreach (var result in mergedList)
            {
                Console.WriteLine(" First name: {0}   Last name: {1}",result.FirstName,result.LastName);
            }
        }
    }
}
