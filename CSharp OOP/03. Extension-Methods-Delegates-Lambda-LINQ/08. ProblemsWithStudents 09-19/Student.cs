// Problem 9: Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.

namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyNumber { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; } // Problem 16: Introduce a property GroupNumber in the Student class.
        
        public Student(string fName, string lName, string fNumber,string email, string tel, List<int> marks, int groupNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FacultyNumber = fNumber;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public static string PrintMarks(List<int> marks)
        {
            string result = "";
            foreach(int mark in marks)
            {
                result += mark+ " ";
            }
            return result;
        }

        public override string ToString()
        {
            return String.Format(" Names:{0} Email:{1} Faculty number:{2} Tel:{3}  Marks:{4}  Group:{5}",
                 this.FirstName + " "+ this.LastName, this.Email, this.FacultyNumber, this.Tel, PrintMarks(this.Marks), this.GroupNumber);
        }
    }
}
