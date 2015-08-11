
namespace _04.PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int ?Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return String.Format("Name: {0} Age: Not specified", this.Name);
            }
            return String.Format("Name: {0} Age: {1}", this.Name, this.Age);
        }
    }
}
