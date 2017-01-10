namespace SchoolClasses
{
    using System.Collections.Generic;

    public interface ITeacher
    {
        ISet<Discipline> Disciplines { get; }
        void AddDiscipline(Discipline subject);
        void RemoveDiscipline(Discipline subject);
    }
}
