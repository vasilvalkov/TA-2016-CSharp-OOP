namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            Student studGero = new Student("Georgi Peshov", 11);
            Teacher teacherRumen = new Teacher("Rumen Zasmyan", new HashSet<Discipline>());

            // DEMONSTRATE COMMENTS
            Console.WriteLine("--- Commenting ---");
            Console.WriteLine(studGero.Comment("Hi there! How's OOP?"));
            teacherRumen.Comment("You have homework to do. Don't miss the deadline!");
            teacherRumen.AddDiscipline(new Discipline(DisciplineTypes.Sport));
            Console.WriteLine(teacherRumen.Disciplines.First().Comment("You have a new teacher!"));
            Console.WriteLine();

            // DEMONSTARATE THE SCHOOL AND SCHOOL CLASS
            Console.WriteLine("--- Introduce new school year ---");
            ISchool school = new School("Vasil Levski");
            SchoolClass class11a = new SchoolClass("11a", new HashSet<IPerson>());
            school.AddClass(class11a);
            Console.WriteLine("Class {0} just started the new school year at school '{1}'", class11a.Id, school.Name);
            Console.WriteLine();
            // Add different kinds of persons into a school class
            class11a.AddPerson(new Student("Pencho", 16));
            class11a.AddPerson(new Student("Gosho", 6));
            class11a.AddPerson(new Teacher("Donchev", new HashSet<Discipline>()));
            // Add a discipline to a teacher
            var donchev = class11a.People.Where(x => x.GetType().Name == "Teacher" && x.Name == "Donchev").First() as Teacher;
            donchev.AddDiscipline(new Discipline(DisciplineTypes.Sport));
            // Print school class members
            Console.WriteLine("--- Class {0} consists of these people ---", class11a.Id);
            foreach (var person in class11a.People)
            {
                if (person is Teacher)
                {
                    Teacher teacher = person as Teacher;
                    Console.WriteLine("{0} of {1} - {2}", person.GetType().Name, teacher.Disciplines.First().DisciplineName , person.Name);
                }
                else
                {
                    Console.WriteLine("{0} - {1}", person.GetType().Name, person.Name);
                }
            }
        }
    }
}
