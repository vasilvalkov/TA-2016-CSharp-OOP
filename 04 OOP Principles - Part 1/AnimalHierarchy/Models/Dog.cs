namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISound, IDog, IAnimal
    {
        public Dog(string name, double age, SexTypes sex)
            : base(name, age, sex)
        {

        }

        public override string Speak()
        {
            return "Rrrrr... Bau! Bau!";
        }
        public void WagTail()
        {
            Console.WriteLine("Wagging tail!");
        }
    }
}