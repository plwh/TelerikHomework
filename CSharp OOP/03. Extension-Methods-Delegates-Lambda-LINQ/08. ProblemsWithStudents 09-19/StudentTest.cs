
namespace _08.ProblemsWithStudents_09_19
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Students;

    class StudentTest
    {

        static void PrintResult(Student[] results)
        {
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        static void Main()
        {
            Console.SetWindowSize(101, 30); // sets console width to 101 and heigth to 30
            // Problem 9: Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. 
            // Order the students by FirstName.
            List<Student> students = new List<Student>()
            {
                new Student("John", "Doe", "232306", "john@abv.bg", "0288888888", new List<int> {2,4},3),
                new Student("Christian", "Bale", "245406", "christian@bale", "0878375837", new List<int> {5,6},2),
                new Student("Garret", "Leith", "212304", "garret@leith", "0297236512", new List<int> {3,2,5},1),
                new Student("Keaton", "Laurence", "256903", "keaton@abv.bg", "0882365351", new List<int> {7,6},5),
                new Student("Samuel", "Montana", "278305", "samuel@montana", "0882939239", new List<int> {3,5},2)
            };

            var problem9_LINQ =
               from student in students
               where student.GroupNumber == 2
               orderby student.FirstName
               select student;
            Console.WriteLine("Students that are from group number 2, ordered by first name:");
            PrintResult(problem9_LINQ.ToArray<Student>());
            // Problem 10: Implement the previous using the same query expressed with extension methods.
            var problem10_extMehods = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName); 
            // Problem 11: Extract all students that have email in abv.bg. Use string methods and LINQ.
            var problem11_extMethods = students.Where(st => st.Email.Contains("abv.bg")); 
            var problem11_LINQ =
                from student in students
                where student.Email.Contains("abv.bg")
                select student;
            Console.WriteLine("\nStudents that have email in abv.bg:");
            PrintResult(problem11_LINQ.ToArray<Student>());
            // Problem 12: Extract all students with phones in Sofia. Use LINQ.
            var problem12 =
                from student in students
                where student.Tel.StartsWith("02")
                select student;
            Console.WriteLine("\nStudents with phones in Sofia:");
            PrintResult(problem12.ToArray<Student>());
            // Problem 13: Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties 
            // – FullName and Marks. Use LINQ.
            var problem13 =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = Student.PrintMarks(student.Marks) };
            Console.WriteLine("\nStudents that have at least one mark Excellent (6):");
            foreach(var pr in problem13)
            {
                Console.WriteLine(" Full name:{0} Marks:{1}",pr.FullName,pr.Marks);
            }
            // Problem 14: Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.
            var problem14 = students.Where(st => st.Marks.Count == 2);
            Console.WriteLine("\nStudents with exactly two marks \"2\":");
            foreach (var pr in problem14)
            {
                Console.WriteLine(" First name:{0} Marks:{1}", pr.FirstName, Student.PrintMarks(pr.Marks));
            }
            // Problem 15: Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit 
            // in the FN).
            var problem15 =
                  from student in students
                  where student.FacultyNumber.EndsWith("06")
                  select student;
            Console.WriteLine("\nMarks of the students that enrolled in 2006:");
            foreach (var pr in problem15)
            {
                Console.WriteLine(" First name:{0} Marks:{1} Faculty Number:{2}", pr.FirstName, Student.PrintMarks(pr.Marks), pr.FacultyNumber);
            }
            // Problem 18: Create a program that extracts all students grouped by GroupNumber and then prints them to the console. Use LINQ.
            var problem18 =
                from student in students
                orderby student.GroupNumber
                select student;
            Console.WriteLine("\nStudents ordered by number of the groups:");
            Console.WriteLine(String.Join(Environment.NewLine, problem18));
            // Problem 19: Rewrite the previous using extension methods.
            var problem19 = students.OrderBy(x => x.GroupNumber).Select(st => st);
        }
    }
}
