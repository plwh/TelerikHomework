
namespace _03.AnimalHierarchy
{
    using System;

    public class Dog : Animals
    {
        private string breed;

        public Dog(string name, int age, bool isFemale, string breed) 
            : base(name,age,isFemale)
        {
            this.Name = name;
            this.Age = age;
            this.IsFemale = isFemale;
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public string ChewBone()
        {
            return string.Format("{0} is chewing a bone", this.Name);
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
