
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class SchoolClass : ICommentable
    {
        private string textIdentifier;
        private List<Teacher> setOfTeachers;

        public SchoolClass(string textIdentifier, params Teacher[] setOfTeachers)
        {
            this.TextIdentifier = textIdentifier;
            this.setOfTeachers = new List<Teacher>();
            this.setOfTeachers.AddRange(setOfTeachers);
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set { this.textIdentifier = value; }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
           return String.Format("Class {0}",this.TextIdentifier);
        }
    }   
}
