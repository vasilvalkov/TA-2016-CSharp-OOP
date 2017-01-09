namespace SchoolClasses
{
    using System;

    public class Person : IPerson
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must have value!");
                }

                this.name = value;
            }
        }
    }
}