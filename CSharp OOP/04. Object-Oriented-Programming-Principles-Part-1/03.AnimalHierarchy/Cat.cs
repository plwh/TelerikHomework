
namespace _03.AnimalHierarchy
{
    using System;

    public class Cat : Animals
    {
        public Cat(string name, int age, bool isFemale)
            : base(name, age, isFemale)
        { 
        
        }

        public string WagTail()
        {
            return string.Format("{0} is wagging tail", this.Name);
        }

        public override string ProduceSound()
        {
            return "Meow!";
        }
    }
}
