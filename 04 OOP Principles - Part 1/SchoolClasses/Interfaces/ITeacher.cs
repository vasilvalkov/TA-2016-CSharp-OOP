namespace SchoolClasses
{
    using System.Collections.Generic;

    public interface ITeacher
    {
        ICollection<Discipline> Disciplines { get; }
        void AddDiscipline(Discipline subject);
        void RemoveDiscipline(Discipline subject);
    }
}
