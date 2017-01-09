namespace AnimalHierarchy
{
    public class Tomcat : Cat, ISound, ICat, IAnimal
    {
        public Tomcat(string name, double age) 
            : base(name, age, SexTypes.Male)
        {
        }

        public override string Speak()
        {
            return "Meow-tommy!";
        }
    }
}