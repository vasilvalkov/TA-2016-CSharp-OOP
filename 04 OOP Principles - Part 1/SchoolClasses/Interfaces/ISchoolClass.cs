﻿namespace SchoolClasses
{
    using System.Collections.Generic;

    public interface ISchoolClass
    {
        string Id { get; }
        ICollection<IPerson> People { get; }

        void AddPerson(IPerson person);
        void RemovePerson(IPerson person);
    }
}