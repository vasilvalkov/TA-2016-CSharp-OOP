namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School : ISchool
    {
        private ICollection<ISchoolClass> classes;
        private string name;

        public School(string name)
        {
            this.name = name;
            classes = new HashSet<ISchoolClass>();
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.classes.Add(schoolClass);
        }
        public void RemoveClass(SchoolClass schoolClass)
        {
            this.classes.Remove(schoolClass);
        }
    }
}