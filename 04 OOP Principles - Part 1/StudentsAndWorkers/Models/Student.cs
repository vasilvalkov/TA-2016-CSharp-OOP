namespace StudentsAndWorkers
{
    using System;

    public class Student : Human, IStudent, IHuman
    {
        private byte grade;

        public Student(string firstname, string lastName, byte grade)
            : base(firstname, lastName)
        {
            this.Grade = grade;
        }

        public byte Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 1 and 12!");
                }

                this.grade = value;
            }
        }
    }
}