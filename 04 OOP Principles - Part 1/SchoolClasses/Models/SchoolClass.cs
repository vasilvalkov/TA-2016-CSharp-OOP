namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : ISchoolClass, IComment
    {
        private readonly string classId;
        private ICollection<IPerson> people;

        public SchoolClass(string id, ICollection<IPerson> people)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Class ID must have a value!");
            }
            else
            {
                this.classId = id; 
            }

            this.people = people;
        }

        public string Id
        {
            get
            {
                return this.classId;
            }
        }
        public ICollection<IPerson> People
        {
            get
            {
                return this.people;
            }
        }

        public void AddPerson(IPerson person)
        {
            this.people.Add(person);
        }
        public void RemovePerson(IPerson person)
        {
            this.people.Remove(person);
        }
        public string Comment(string text)
        {
            return string.Format("Class {0} comments: {1}", this.Id, text);
        }
    }
}