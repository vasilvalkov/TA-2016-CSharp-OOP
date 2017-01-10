namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School : ISchool
    {
        private ISet<ISchoolClass> classes;
        private string name;

        public School (string name)
            : this(name, new HashSet<ISchoolClass>())
        {
        }
        public School (string name, ISet<ISchoolClass> classes)
        {
            this.name = name;
            this.classes = classes;
        }

        public string Name { get { return this.name; } }

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