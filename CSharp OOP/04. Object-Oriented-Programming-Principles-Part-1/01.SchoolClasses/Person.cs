
namespace _01.SchoolClasses
{
    using System;

    class Person : ICommentable
    {
        private string name;

        protected Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Comment { get; set; }
    }
}
