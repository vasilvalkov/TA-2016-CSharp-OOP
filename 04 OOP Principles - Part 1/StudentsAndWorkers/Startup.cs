namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {   // Initialize a list of 10 students
            List<Student> students = new List<Student>
            {
                new Student("Pesho", "Georgiev", 11),
                new Student("Genadi", "Stoyanov", 1),
                new Student("Mara", "Genovevova", 6),
                new Student("Krum", "Meteorov", 9),
                new Student("Ceca", "Srabska", 11),
                new Student("Tosho", "Toshov", 11),
                new Student("Genka", "Koceva", 10),
                new Student("Kose", "Bosev", 2),
                new Student("Mariyka", "Georgieva", 6),
                new Student("Keremidka", "Tuhlova", 12)
            };
            // Initialize a list of 10 workers
            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Ivanov", 320, 8, 5),
                new Worker("Strahil", "Mechkov", 295, 8, 5),
                new Worker("Koshara", "Kokoshkova", 800, 2, 3),
                new Worker("Yunak", "Balkanski", 104, 12, 7),
                new Worker("Rabotar", "Trujenikov", 40, 10, 6),
                new Worker("Skatavka", "Muhlova", 560, 2, 5),
                new Worker("Vasil", "Vasilev", 450, 8, 5),
                new Worker("Alexander", "Aleksandrov", 390, 8, 5),
                new Worker("Sashka", "Shushonova", 380, 6, 5),
                new Worker("Bay", "Ganyo", 50, 1, 1)
            };
            // sort students by grade in ascending order
            Console.WriteLine("--- Students ---");
            var orderedStudents = students.OrderBy(s => s.Grade).ToList();
            orderedStudents.ForEach(st => Console.WriteLine("{0} - grade: {1}",st.FullName, st.Grade));
            Console.WriteLine();
            // sort workers by money per hour in descending order
            Console.WriteLine("--- Workers ---");
            var orderedWorkers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();
            orderedWorkers.ForEach(w => Console.WriteLine("{0} - earns {1:C2}/h", w.FullName, w.MoneyPerHour()));
            Console.WriteLine();
            // merge the lists and sort them by first name and last name
            Console.WriteLine("--- Merged list ---");
            List<IHuman> merged = new List<IHuman>();
            merged.AddRange(students);
            merged.AddRange(workers);

            merged.OrderBy(x => x.FirstName)
                  .ThenBy(x => x.LastName)
                  .ToList()
                  .ForEach(h => Console.WriteLine("{0,-22} - {1}", h.FullName, h.GetType().Name));
        }
    }
}