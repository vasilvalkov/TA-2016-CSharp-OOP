namespace SchoolClasses
{
    public interface ISchool
    {
        string Name { get; }

        void AddClass(ISchoolClass schoolClass);
        void RemoveClass(ISchoolClass schoolClass);
    }
}