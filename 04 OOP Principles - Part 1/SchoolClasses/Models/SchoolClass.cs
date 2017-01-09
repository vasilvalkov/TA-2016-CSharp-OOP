namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : ISchoolClass, IComment
    {
        private ICollection<Person> people;
        private string classId;

        public SchoolClass(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Class ID must have a value!");
            }
            else
            {
                this.classId = id; 
            }

            this.people = new HashSet<Person>();
        }

        public string Id
        {
            get
            {
                return this.classId;
            }
        }
        public ICollection<Person> People
        {
            get
            {
                return this.people;
            }
        }

        public void AddPerson(Person person)
        {
            this.people.Add(person);
        }
        public void RemovePerson(Person person)
        {
            this.people.Remove(person);
        }
        public string Comment(string text)
        {
            return string.Format("Class {0} comments: {1}", this.Id, text);
        }
    }
}