namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, double age, SexTypes sex) 
            : base(name, age, sex)
        {
        }

        public override string Speak()
        {
            return "Meow!";
        }
        public void Purr()
        {
            Console.WriteLine("Purrrrrrrr...");
        }
    }
}