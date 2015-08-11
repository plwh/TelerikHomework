
namespace _01.SchoolClasses
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, params Discipline[] disciplines) : base(name)
        { 
            this.disciplines = new List<Discipline>();
            this.disciplines.AddRange(disciplines);
        }

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(disciplines); }
        }

       
        public void AddDiscipline(Discipline x)
        {
            this.disciplines.Add(x);
        }

        public void RemoveDiscipline(Discipline x)
        {
            this.disciplines.Remove(x);
        }

        public override string ToString()
        {
           StringBuilder result = new StringBuilder();
           result.AppendLine("Teacher name:" + base.Name);
           result.AppendLine("Teacher disciplines:\n" + (string.Join("\n\n", Disciplines)));
           return result.ToString();
        }
    }
}
