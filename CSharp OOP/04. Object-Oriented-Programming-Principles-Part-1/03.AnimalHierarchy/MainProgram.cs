/* Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All 
animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and 
sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of
animals and calculate the average age of each kind of animal using a static method (you may use LINQ). */

namespace _03.AnimalHierarchy
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            Cat[] arrayOfCats = new Cat[] 
            { 
                new Cat("Betty",1,true),
                new Cat("Tom",3,false)
            };

            Kitten[] arrayOfKittens = new Kitten[]
            {
                new Kitten("Johny",1),
                new Kitten("Persia",2)
            };

            Tomcat[] arrayOfTomcats = new Tomcat[]
            {
                new Tomcat("John",4),
                new Tomcat("Toby",2)
            };

            Dog[] arrayOfDogs = new Dog[]
            {
                new Dog("Oliver", 2, false, "German Shepherd"),
                new Dog("Olivia",3, true, "Shih Tzu")
            };

            Frog[] arrayOfFrogs = new Frog[]
            {
                new Frog("Candy",2,true),
                new Frog("Abidin",4,false) 
            };

            Console.WriteLine("Average age of cats: {0}",Animals.CalcAvgAge(arrayOfCats));
            Console.WriteLine("Average age of kittens: {0}", Animals.CalcAvgAge(arrayOfKittens));
            Console.WriteLine("Average age of tomcats: {0}", Animals.CalcAvgAge(arrayOfTomcats));
            Console.WriteLine("Average age of dogs: {0}", Animals.CalcAvgAge(arrayOfDogs));
            Console.WriteLine("Average age of frogs: {0}", Animals.CalcAvgAge(arrayOfFrogs));
            Console.WriteLine("\nAnimal sounds:\n {0}\n {1}\n {2}\n",
                              arrayOfCats[1].ProduceSound(),arrayOfDogs[0].ProduceSound(),arrayOfFrogs[1].ProduceSound());
            Console.WriteLine("Animal actions:\n {0}\n {1}\n {2}\n",
                              arrayOfCats[0].WagTail(),arrayOfDogs[1].ChewBone(),arrayOfFrogs[1].Leap());
            
        }
    }
}
