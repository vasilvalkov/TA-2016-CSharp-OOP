namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : Person, ITeacher, IComment
    {
        private ICollection<Discipline> disciplines;

        public Teacher(string name) 
            : base(name)
        {
            this.disciplines = new HashSet<Discipline>();
        }

        public ICollection<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
        }

        public void AddDiscipline(Discipline subject)
        {
            this.disciplines.Add(subject);
        }

        public void RemoveDiscipline(Discipline subject)
        {
            this.disciplines.Remove(subject);
        }

        public string Comment(string text)
        {
            return string.Format($"The teacher {this.Name} comments: {text}");
        }
    }
}