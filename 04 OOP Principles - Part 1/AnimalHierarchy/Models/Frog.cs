namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal, ISound, IFrog, IAnimal
    {
        public Frog(string name, double age, SexTypes sex)
            : base(name, age, sex)
        {
        }

        public override string Speak()
        {
            return "Kwack!";
        }
        public void Metamorphose()
        {
            Console.WriteLine("I metamorphosed and now I am adult frog");
        }
    }
}