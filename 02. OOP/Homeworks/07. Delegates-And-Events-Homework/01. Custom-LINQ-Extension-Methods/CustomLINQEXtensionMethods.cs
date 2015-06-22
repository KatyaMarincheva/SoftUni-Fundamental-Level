namespace _01.Custom_LINQ_Extension_Methods
{
    using System;
    using System.Collections.Generic;

    internal class CustomLINQEXtensionMethods
    {
        internal static void Main(string[] args)
        {
            // WhereNot example
            var nums = new List<int>()
            {
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var filteredCollection = nums.WhereNot(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollection));

            var students = new List<Student>()
            {
                new Student("Asya", 6),
                new Student("Ivan", 4),
                new Student("Penka", 5),
                new Student("Grigor", 3)
            };

            // Max/Min Examples
            // max name and grade values
            Console.WriteLine(students.Max(student => student.Grade));
            Console.WriteLine(students.Max(student => student.Name));

            // min name and grade values
            Console.WriteLine(students.Min(student => student.Grade));
            Console.WriteLine(students.Min(student => student.Name));

            // max student by name and grade
            Console.WriteLine(students.MaxStudent(student => student.Name));
            Console.WriteLine(students.MaxStudent(student => student.Grade));

            // min student by name and grade
            Console.WriteLine(students.MinStudent(student => student.Name));
            Console.WriteLine(students.MinStudent(student => student.Grade));
        }
    }
}
