
namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animals
    {
        public Frog(string name, int age, bool isFemale)
            : base(name, age, isFemale)
        { 
            
        }

        public string Leap()
        {
            return string.Format("{0} is leaping", this.Name);
        }

        public override string ProduceSound()
        {
            return "Quack!";
        }
    }
}
