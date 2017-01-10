namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : Person, ITeacher, IComment
    {
        private ISet<Discipline> disciplines;

        public Teacher(string name, ISet<Discipline> disciplines) 
            : base(name)
        {
            this.disciplines = disciplines;
        }

        public ISet<Discipline> Disciplines
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