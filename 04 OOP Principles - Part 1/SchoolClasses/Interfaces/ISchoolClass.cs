namespace SchoolClasses
{
    using System.Collections.Generic;

    public interface ISchoolClass
    {
        string Id { get; }
        ICollection<Person> People { get; }

        void AddPerson(Person person);
        void RemovePerson(Person person);
    }
}
