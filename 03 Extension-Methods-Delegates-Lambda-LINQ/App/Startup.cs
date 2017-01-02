namespace App
{
    using Extensions;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    
    class Startup
    {
        static void Main()
        {   // Problem 1
            //TestStringBuilderSubstring();
            // Problem 2
            //TestIEnumerableExtensions();
            // Problem 3
            #region Declaring students to use in the next problems
            var marks1 = new List<Mark>
            {
                new Mark("Maths", MarkType.Excellent),
                new Mark("Maths", MarkType.Excellent),
                new Mark("Biology", MarkType.Good),
                new Mark("Geography", 2),
                new Mark("Chemistry", 3),
                new Mark("Programming with C#", 2),
            };
            var marks2 = new List<Mark>
            {
                new Mark("Maths", MarkType.Good),
                new Mark("Maths", MarkType.Satisfactory),
                new Mark("Biology", 3),
                new Mark("Geography", 5),
                new Mark("Chemistry", 4),
                new Mark("Programming with C#", 3),
            };
            var marks3 = new List<Mark>
            {
                new Mark("Maths", 5),
                new Mark("Maths", 5),
                new Mark("Biology", 3),
                new Mark("Geography", 4),
                new Mark("Chemistry", 2),
                new Mark("Programming with C#", 2),
            };
            var marks4 = new List<Mark>
            {
                new Mark("Maths", 2),
                new Mark("Maths", 5),
                new Mark("Biology", 6),
                new Mark("Geography", 4),
                new Mark("Chemistry", 3),
                new Mark("Programming with C#", 6),
            };
            var marks5 = new List<Mark>
            {
                new Mark("Maths", MarkType.Excellent),
                new Mark("Maths", MarkType.Excellent),
                new Mark("Biology", MarkType.Good),
                new Mark("Geography", 2),
                new Mark("Chemistry", 2),
                new Mark("Programming with C#", 6),
            };

            var students = new List<Student>
            {
                new Student("Pesho", "Goshov", 18, "102406", 023131313, 3, "pesho@abv.bg", marks1),
                new Student("Gosho", "Peshov", 20, "103105", 0888888888, 2, "c#@ms.net", marks2),
                new Student("Mariyka", "Strahilova", 25, "112906", 0111122233, 3, "mariyka@abv.bg", marks3),
                new Student("Stoyanka", "Toshova", 21, "139006", 024343434, 2, "edi@koi.si", marks4),
                new Student("Stoyan", "Toshov", 26, "139105", 0101010101, 1, "someone@somewhere.com", marks5)
            };
            #endregion
            //TestFirstFeboreLastLINQ(students);
            // Problem 4
            //TestAgeRangeLINQ(students);
            // Problem 5
            //TestOrderStudentsExtMethods(students);
            //TestOrderStudentsLINQ(students);
            // Problem 6
            //var nums = new List<int> { 1, 3, 7, 21, 33, 45, 210 };
            //TestDivisibleTo7and3(nums);
            //TestDivisibleTo7and3LINQ(nums);
            // Problem 7
            //Execute timerPrinting = PrintTimeNow;
            //timerPrinting += PrintTimeIn4Hours;
            //Timer.RepeatEvery(5, timerPrinting);
            // Problem 8 *

            // Problem 9
            //TestStudentGroupsLINQ(students);
            // Problem 10
            //TestStudentGroupsExtMethods(students);
            // Problem 11
            //TestExtractStudentsByEmail(students);
            // Problem 12
            //TestExtractStudentsByPhone(students);
            // Problem 13
            //TestExtractStudentsByMarks(students);
            // Problem 14
            //TestExtractStudentsWithTwoMarksExtMethods(students);
            // Problem 15
            //TestExtractMarks(students);
            // Problem 16 *
            //TestGroups(students);
            // Problem 17
            //TestLongestString();
            // Problem 18
            //TestGroupedByGroupNumberLINQ(students);
            // Problem 19
            //TestGroupedByGroupNumberExtMethods(students);
            // Problem 20 *

        }

        private static void PrintTimeNow()
        {
            Console.Clear();
            Console.WriteLine("The time now is: {0: HH:mm:ss}", DateTime.Now);
        }
        private static void PrintTimeIn4Hours()
        {
            Console.WriteLine("The time in four hours will be: {0: HH:mm:ss}", DateTime.Now.AddHours(4));
        }

        private static void TestGroupedByGroupNumberExtMethods(List<Student> students)
        {
            Console.WriteLine("--- All students by group ---");

            var studentsInGroups = students
                                    .GroupBy(student => student.GroupNumber)
                                    .OrderBy(g => g.Key)
                                    .ToList();

            foreach (var group in studentsInGroups)
            {
                Console.WriteLine("Group {0}", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine("{0}", student.FullName);
                }

                Console.WriteLine();
            }
        }

        private static void TestGroupedByGroupNumberLINQ(List<Student> students)
        {
            Console.WriteLine("--- All students by group ---");

            var studentsInGroups = from stud in students
                                   group stud by stud.GroupNumber into g
                                   orderby g.Key
                                   select g;

            foreach (var group in studentsInGroups)
            {
                Console.WriteLine("Group {0}", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine("{0}", student.FullName);
                }

                Console.WriteLine();
            }
        }

        private static void TestLongestString()
        {
            var strArray = new string[] { "One", "Three", "Four", "Seven", "Eleven", "Thirteen" };
            Console.WriteLine("--- All strings ---");
            Console.WriteLine(string.Join(", ", strArray));
            Console.WriteLine();

            var longestString =
                from str in strArray
                where str.Length == strArray.Max(st => st.Length)
                select str;

            Console.WriteLine("--- Longest string ---");
            Console.WriteLine(longestString.ToString<string>());
        }

        private static void TestGroups(List<Student> students)
        {
            var groupsList = new List<Group>
            {
               new Group(1, "Geography"),
               new Group(2, "Mathematics"),
               new Group(3, "Economics")
            };

            var mathsStudents = 
                students.Join(groupsList,
                              student => student.GroupNumber,
                              dept => dept.GroupNumber,
                              (student, dept) => 
                              new { StudentName = student.FullName, Department = dept.DepartmentName })
                        .Where(student => student.Department == "Mathematics")
                        .ToList();

            mathsStudents.ForEach(result => Console.WriteLine(string.Join(", ", result.StudentName)));
        }
        
        private static void TestExtractMarks(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            students.ForEach(st => Console.WriteLine("{0}'s faculty number: {1}", st.FullName, st.FN));

            var query = students
                        .Where(student => student.FN.EndsWith("06"))
                        .Select(student => new { FullName = student.FullName, Marks = student.Marks })
                        .ToList();

            Console.WriteLine();

            Console.WriteLine("--- All students that enrolled in 2006... ---");
            query.ForEach(st => Console.WriteLine(st.FullName));
            Console.WriteLine();

            Console.WriteLine("--- ...and their marks ---");
            query.ForEach(st => st.Marks.ForEach(mark => Console.WriteLine("{0}: {1}", mark.Discipline, (int)mark.Score)));
        }

        private static void TestExtractStudentsWithTwoMarksExtMethods(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0}'s marks are:", student.FullName);

                foreach (var mark in student.Marks)
                {
                    Console.WriteLine("{0}: {1} ({2})", mark.Discipline, mark.Score, (int)mark.Score);
                }
                Console.WriteLine();
            }

            var query = students
                        .Where(student => student.Marks.Count(mark => (int)mark.Score == 2) == 2)
                        .Select(student => new { FullName = student.FullName, Marks = student.Marks })
                        .ToList();

            Console.WriteLine("--- Students with exactly two marks (2) ---");
            query.ForEach(st => Console.WriteLine(st.FullName));
        }

        private static void TestExtractStudentsByMarks(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0}'s marks are:", student.FullName);

                foreach (var mark in student.Marks)
                {
                    Console.WriteLine("{0}: {1} ({2})", mark.Discipline, mark.Score, (int)mark.Score);
                }
                Console.WriteLine();
            }

            var query =
                from student in students
                where student.Marks.Any(m => (int)m.Score == 6)
                select new { FullName = student.FullName, Marks = student.Marks };

            Console.WriteLine("--- Students with at lest one mark (6) ---");
            foreach (var student in query)
            {
                Console.WriteLine(student.FullName);
            }
        }

        private static void TestExtractStudentsByPhone(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0}'s phone number is: {1}",
                    student.FullName,
                    student.PhoneNumber.ToString(new string('0', student.PhoneNumber.ToString().Length + 1)));
            }

            var query =
                from student in students
                where student.PhoneNumber
                             .ToString(new string('0', student.PhoneNumber.ToString().Length + 1))
                             .StartsWith("02")
                select student;

            Console.WriteLine();
            Console.WriteLine("Students with phone number in Sofia: {0}", query.ToString<Student>());
        }

        private static void TestExtractStudentsByEmail(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0}'s e-mail is: {1}", student.FullName, student.Email);
            }

            var query =
               from student in students
               where student.Email.EndsWith("abv.bg")
               select student;

            Console.WriteLine();
            Console.WriteLine("Students with e-mail @ abv.bg: {0}", query.ToString<Student>());
        }

        private static void TestStudentGroupsExtMethods(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0} is in group {1}", student.FullName, student.GroupNumber);
            }

            var query = students
                        .Where(student => student.GroupNumber == 2)
                        .OrderBy(student => student.FirstName)
                        .ToList();

            Console.WriteLine();
            Console.WriteLine("Students in group 2: {0}", query.ToString<Student>());
        }

        private static void TestStudentGroupsLINQ(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0} is in group {1}", student.FullName, student.GroupNumber);
            }

            var query = from student in students
                        where student.GroupNumber == 2
                        orderby student.FirstName
                        select student;

            Console.WriteLine();
            Console.WriteLine("Students in group 2: {0}", query.ToString<Student>());
        }

        private static void TestDivisibleTo7and3(List<int> nums)
        {
            Console.WriteLine("--- All numbers ---");
            Console.WriteLine(nums.ToString<int>());
            Console.WriteLine("--- Numbers divisible to 7 and 3 ---");

            var divisibleTo7and3 = nums.FindAll(x => x % (7 * 3) == 0);

            Console.WriteLine(divisibleTo7and3.ToString<int>());
        }

        private static void TestDivisibleTo7and3LINQ(List<int> nums)
        {
            Console.WriteLine("--- Numbers divisible to 7 and 3 using Linq ---");

            var query = from num in nums
                        where num % (7 * 3) == 0
                        select num;

            Console.WriteLine(query.ToString<int>());
        }

        private static void TestOrderStudentsExtMethods(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            Console.WriteLine(students.ToString<Student>());
            Console.WriteLine();

            Console.WriteLine("--- Ordered students with Extension methods ---");
            var orderedList = students
                            .OrderByDescending(st => st.FirstName)
                            .ThenByDescending(st => st.LastName)
                            .ToList();

            Console.WriteLine(orderedList.ToString<Student>());
            Console.WriteLine();
        }

        private static void TestOrderStudentsLINQ(List<Student> students)
        {
            Console.WriteLine("--- Ordered students with Linq ---");
            var query = from st in students
                        orderby st.FirstName descending, st.LastName descending
                        select st;

            Console.WriteLine(query.ToString<Student>());
        }

        private static void TestAgeRangeLINQ(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            foreach (var student in students)
            {
                Console.WriteLine("{0} is {1} years old", student.FullName, student.Age);
            }
            Console.WriteLine();

            var query =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("--- All students between 18 and 24 years of age---");
            Console.WriteLine(query.ToString<Student>());
        }

        private static void TestFirstFeboreLastLINQ(List<Student> students)
        {
            Console.WriteLine("--- All students ---");
            Console.WriteLine(students.ToArray().ToString<Student>());
            var query =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("--- Filtered students ---");
            Console.WriteLine(query.ToString<Student>());
        }

        private static void TestIEnumerableExtensions()
        {
            Console.WriteLine();
            Console.WriteLine("--- IEnumerable extensions ---");
            var intList = new List<long>() { 1, 3, 2, 4 };
            Console.WriteLine("Collection <int>: {0}", intList.ToString<long>());
            Console.WriteLine("Sum is: {0}", intList.SumOf(num => Convert.ToUInt32(num)));
            Console.WriteLine("Product is: {0}", intList.ProductOf(num => Convert.ToUInt64(num)));
            Console.WriteLine("Min int is: {0}", intList.MinOf());
            Console.WriteLine("Max int is: {0}", intList.MaxOf());
            Console.WriteLine("Average is: {0}", intList.AverageOf(num => Convert.ToDouble(num)));
            var doubleList = new List<double>() { 1.3, 3.14, 2, 41.231 };
            Console.WriteLine("Collection <double>: {0}", doubleList.ToString<double>());
            Console.WriteLine("Sum is: {0}", doubleList.SumOf(num => Convert.ToDouble(num)));
            Console.WriteLine("Product is: {0}", doubleList.ProductOf(num => Convert.ToDecimal(num)));
            Console.WriteLine("Min int is: {0}", doubleList.MinOf());
            Console.WriteLine("Max int is: {0}", doubleList.MaxOf());
            Console.WriteLine("Average is: {0}", doubleList.AverageOf(num => Convert.ToDouble(num)));
            var stringList = new List<string> { "Pesho", "Chavdar", "Gosho", "Mariyka" };
            Console.WriteLine("Collection <string>: {0}", stringList.ToString<string>());
            Console.WriteLine("Min string is: {0}", stringList.MinOf());
            Console.WriteLine("Max string is: {0}", stringList.MaxOf());
        }

        private static void TestStringBuilderSubstring()
        {
            Console.WriteLine("--- StringBuilder.Substring extension ---");
            StringBuilder sentence = new StringBuilder();
            sentence.Append("These are some words to extract from.");
            Console.WriteLine("All text: {0}", sentence.ToString());
            sentence = sentence.Substring(15, 16);
            Console.WriteLine("Substring: {0}", sentence.ToString());
        }
    }
}