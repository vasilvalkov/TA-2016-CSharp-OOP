namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private readonly SexTypes sex;

        public Animal(string name, double age, SexTypes sex)
        {
            this.Name = name;
            this.Age = age;
            this.sex = sex;
        }

        public double Age { get; private set; }
        public string Name { get; set; }
        public SexTypes Sex
        {
            get
            {
                return this.sex;
            }
        }

        public abstract string Speak();
    }
}