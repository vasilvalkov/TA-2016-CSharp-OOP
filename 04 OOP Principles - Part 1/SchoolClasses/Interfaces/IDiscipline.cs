namespace SchoolClasses
{
    public interface IDiscipline
    {
        DisciplineTypes DisciplineName { get; }
        ushort NumberOfLectures { get; }
        byte NumberOfExercises { get; }

        void SetNumberOfLectures(ushort lecturesCount);
        void SetNumberOdExercises(byte exercisesCount);
    }
}