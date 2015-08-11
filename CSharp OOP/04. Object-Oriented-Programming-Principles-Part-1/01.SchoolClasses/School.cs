
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class School
    {
        private List<SchoolClass> schoolClasses;

        public School(params SchoolClass[] classes)
        {
            this.Classes = new List<SchoolClass>();
            this.Classes.AddRange(schoolClasses); 
        }

        public List<SchoolClass> Classes
        {
            get { return this.schoolClasses ;}
            set { this.schoolClasses = value;}
        }

        public void AddClass(SchoolClass x)
        {
            this.schoolClasses.Add(x);
        }

        public void RemoveClass(SchoolClass x)
        {
            this.schoolClasses.Remove(x);
        }
    }
}
