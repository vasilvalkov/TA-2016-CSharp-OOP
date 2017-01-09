namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound, ICat, IAnimal
    {
        public Kitten(string name, double age)
            : base(name, age, SexTypes.Female)
        {
        }

        public override string Speak()
        {
            return "Meow-kitty!";
        }
    }
}