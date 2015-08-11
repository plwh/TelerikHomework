
namespace _01_03.StudentClass
{
    using System;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private decimal ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private int course;

        public Student(string firstName, string middleName, string lastName, decimal ssn,
                       string address, string mobilePhone, string email, int course,
                       Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        { 
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public decimal SSN
        {
            get { return this.ssn;}
            set { this.ssn = value;}
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name:{0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendLine("SSN:" + this.SSN);
            sb.AppendLine("Permanent address:" + this.Address);
            sb.AppendLine("Mobile phone:" + this.MobilePhone);
            sb.AppendLine("E-mail:" + this.Email);
            sb.AppendLine("Course:" + this.Course);
            sb.AppendLine("Specialty:" + this.Specialty);
            sb.AppendLine("University:" + this.University);
            sb.AppendLine("Faculty:" + this.Faculty);
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return this.Address.GetHashCode() ^ this.MobilePhone.GetHashCode(); 
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public object Clone()
        {
            Student temp = new Student(this.FirstName, this.MiddleName, this.LastName,
                                       this.SSN, this.Address, this.mobilePhone, this.Email,
                                       this.Course, this.Specialty, this.University, this.Faculty);
            return temp;
        }

        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            if (this.FirstName.CompareTo(otherStudent.FirstName) == 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
            return this.FirstName.CompareTo(otherStudent.FirstName);
        }
    }
}
