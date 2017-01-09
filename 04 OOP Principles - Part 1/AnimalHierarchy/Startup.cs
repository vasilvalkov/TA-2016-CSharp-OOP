namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {   // Create arrays of different kinds of animals 
            IFrog[] frogs = new IFrog[]
            {
                new Frog("Jaba", 0.2, SexTypes.Female),
                new Frog("Java", 0.7, SexTypes.Male),
                new Frog("Yoda", 1, SexTypes.Male),
            };
            IAnimal[] mixed = new IAnimal[]
            {
                new Cat("Lucky", 6, SexTypes.Male),
                new Dog("Cezar", 5, SexTypes.Male),
                new Tomcat("Gosho", 3),
                new Frog("Rumba", 2.2, SexTypes.Female)
            };

            IDog[] dogs = new IDog[]
            {
                new Dog("Sharo", 1, SexTypes.Male),
                new Dog("Raya", 0.3, SexTypes.Female),
            };

            ICat[] cats = new ICat[]
            {
                new Tomcat("Tom", 0.6),
                new Kitten("Maya", 3),
                new Cat("Garfield", 7, SexTypes.Male)
            };
            // Introduce animals
            List<IAnimal> animals = new List<IAnimal>();

            animals.AddRange(frogs);
            animals.AddRange(mixed);
            animals.AddRange(dogs);
            animals.AddRange(cats);
            Console.WriteLine("--- All animals ---");
            animals.ForEach(a => Console.WriteLine("{0} is a {1} and its age is {2}. It speaks {3}",
                                                    a.Name,
                                                    a.GetType().Name,
                                                    a.Age,
                                                    a.Speak()));
            Console.WriteLine();
            // Calculate the average age of each kind of animal
            Console.WriteLine("The average age of all animals is {0:F2}", animals.Select(x => x.Age).Average());
        }
    }
}