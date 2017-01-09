namespace StudentsAndWorkers
{
    using System;

    public abstract class Human : IHuman
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                ValidateName(value);
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                ValidateName(value);
                this.lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        private static void ValidateName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The first name must have value!");
            }
        }
    }
}