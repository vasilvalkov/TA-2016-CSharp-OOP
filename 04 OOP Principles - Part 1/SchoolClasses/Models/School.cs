namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School : ISchool
    {
        private ICollection<ISchoolClass> classes;
        private string name;

        public School(string name, ICollection<ISchoolClass> classes)
        {
            this.name = name;
            this.classes = classes;
        }

        public void AddClass(ISchoolClass schoolClass)
        {
            this.classes.Add(schoolClass);
        }
        public void RemoveClass(ISchoolClass schoolClass)
        {
            this.classes.Remove(schoolClass);
        }
    }
}