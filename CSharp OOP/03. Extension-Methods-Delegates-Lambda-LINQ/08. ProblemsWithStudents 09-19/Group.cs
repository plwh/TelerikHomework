// Problem 16: Create a class Group with properties GroupNumber and DepartmentName.

namespace _08.ProblemsWithStudents_09_19
{
    using System;

    class Group
    {
        private int groupNumber;
        private string departmenName;

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public string DepartmentName
        {
            get { return this.departmenName; }
            set { this.departmenName = value; }
        }

        public Group(int groupNumber)
        {
            this.GroupNumber = groupNumber;
        }

        public Group(int groupNumber, string departmentName)
        {
            this.DepartmentName = departmentName;
        }
    }
}
