namespace AnimalHierarchy
{
    public interface IAnimal : ISound
    {
        double Age { get; }
        string Name { get; set; }
        SexTypes Sex { get; }
    }
}