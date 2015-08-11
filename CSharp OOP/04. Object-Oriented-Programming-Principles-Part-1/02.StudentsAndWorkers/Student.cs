
namespace _02.StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade):base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            return String.Format(" First name: {0}   Last name: {1}   Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
