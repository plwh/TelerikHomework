
namespace _03.AnimalHierarchy
{
    using System;
    using System.Linq;

    public abstract class Animals : ISound
    {
        private string name;
        private int age;
        private bool isFemale;

        public Animals(string name, int age, bool isFemale)
        {
            this.Name = name;
            this.Age = age;
            this.IsFemale = isFemale;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public bool IsFemale
        {
            get { return this.isFemale; }
            set { this.isFemale = value; }
        }

        public static double CalcAvgAge(Animals [] array)
        {
            return array.Average(x => x.Age);
        }

        public abstract string ProduceSound();


    }
}
