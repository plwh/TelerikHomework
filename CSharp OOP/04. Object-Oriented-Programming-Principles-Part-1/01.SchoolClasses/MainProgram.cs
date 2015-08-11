﻿/* We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines.
Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and 
number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments 
(free text block). Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the
class hierarchy and create a class diagram with Visual Studio. */

namespace _01.SchoolClasses
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Student student = new Student("John Doe", 4);

            Console.WriteLine(student);

            Teacher teacher = new Teacher("Jeff Black", new Discipline("Chemistry",10,20),new Discipline("Physics",15,25));

            Console.WriteLine(teacher);

            School school = new School(new SchoolClass("12b", teacher));
        }
    }
}
