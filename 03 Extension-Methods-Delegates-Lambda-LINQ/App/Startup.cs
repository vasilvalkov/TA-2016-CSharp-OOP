namespace App
{
    using Extensions;
    using Models;
    using System;
    using System.Collections.Generic;
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
            #region Declaring students
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
                new Mark("Chemistry", 6),
                new Mark("Programming with C#", 3),
            };
            var marks3 = new List<Mark>
            {
                new Mark("Maths", 5),
                new Mark("Maths", MarkType.Excellent),
                new Mark("Biology", 3),
                new Mark("Geography", 6),
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

            var students = new Student[]
            {
                new Student("Pesho", "Goshov", 18, "102406", null, 339, null, marks1),
                new Student("Gosho", "Peshov", 20, "103105", 0888888888, 340, "c#@ms.net", marks2),
                new Student("Mariyka", "Strahilova", 25, "112906", 0111122233, 339, null, marks3),
                new Student("Stoyanka", "Toshova", 21, "139006", null, 339, "edi@koi.si", marks4),
                new Student("Stoyan", "Toshov", 26, "139105", 0101010101, 340, "someone@somewhere.com", marks5)
            };
            #endregion
            //TestFirstFeboreLast(students);
            // Problem 4

            var query = students.Where(st => st.Age >= 18 && st.Age <= 24).ToArray();
            Console.WriteLine(query.ToString<Student>());
        }

        private static void TestFirstFeboreLast(Student[] students)
        {
            Console.WriteLine("--- All students ---");
            Console.WriteLine(students.ToArray().ToString<Student>());
            var query = students.Where(st => st.FirstName.CompareTo(st.LasttName) < 0).ToArray();
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