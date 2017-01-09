namespace SchoolClasses
{
    public class Discipline : IDiscipline, IComment
    {
        public Discipline(DisciplineTypes discipline)
        {
            this.DisciplineName = discipline;
        }

        public DisciplineTypes DisciplineName { get; private set; }
        public ushort NumberOfLectures { get; private set; }
        public byte NumberOfExercises { get; private set; }

        public void SetNumberOfLectures(ushort lecturesCount)
        {
            this.NumberOfLectures = lecturesCount;
        }
        public void SetNumberOdExercises(byte exercisesCount)
        {
            this.NumberOfExercises = exercisesCount;
        }
        public string Comment(string text)
        {
            return string.Format($"{this.DisciplineName} comments: {text}");
        }
    }
}