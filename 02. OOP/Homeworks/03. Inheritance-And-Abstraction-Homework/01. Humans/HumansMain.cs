using System;
using System.Collections.Generic;
using System.Linq;
using _01.Humans.People;

namespace _01.Humans
{
    class HumansMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("First", "Student", "bbbbb"),
                new Student("Second", "Student", "aaaaa"),
                new Student("Third", "Student", "ccccc"),
                new Student("Fourth", "Student", "ddddd"),

                // new Student("Invalid", "Number", "wer");
            };

            var sortedStudents = students.OrderBy(x => x.FacultyNumber);
            Console.WriteLine("Ordered students (by faculty number):");
            PrintList(sortedStudents);

            List<Worker> workers = new List<Worker>()
            {
                new Worker("First", "Worker", 23m, 16),
                new Worker("Second", "Worker", 55.99m, 24),
                new Worker("Third", "Worker", 0.1m, 0),
                new Worker("Fourth", "Worker", 100000m, 1),

                // new Worker("Invalid", "Salary", -1, 2)
                // new Worker("Invalid", "Work Hours", 1, -1)
            };

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Ordered workers (by hourly salary):");
            PrintList(sortedWorkers);

            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            var sortedPeople = people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("Ordered people (by first and last name):");
            PrintList(sortedPeople);
        }

        private static void PrintList<T>(IOrderedEnumerable<T> list)
        {
            foreach (var human in list)
            {
                Console.WriteLine(human);
            }

            Console.WriteLine();
        }
    }
}
