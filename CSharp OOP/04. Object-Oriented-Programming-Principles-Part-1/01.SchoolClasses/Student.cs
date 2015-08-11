
namespace _01.SchoolClasses
{
    using System;

    class Student : Person, ICommentable
    {
        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }

        public override string ToString()
        {
            return String.Format("Student name: {0} Class number: {1}",this.Name,this.ClassNumber);
        }
    }
}
