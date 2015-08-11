// Problem 1: Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, 
//            course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods,
//            inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
// Problem 2: Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
// Problem 3: Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security 
//            number (as second criteria, in increasing order).

namespace _01_03.StudentClass
{
    using System;

    public class MainProgram
    {
        static void Main()
        {
            Student firstStudent = new Student("Gosho","Goshev","Petrov",123456789,"22 Jump Street","0888888888","gosho@gosho.bg",
                                           1,Specialty.ComputerScience,University.SofiaUniversity,Faculty.ComputerAndInformationScience);
            Console.WriteLine("First student info:\n"+ firstStudent);
            var secondStudent = firstStudent.Clone();
            Console.WriteLine("Second student info(clone of first):\n" + secondStudent);
        }
    }
}
