using System;
using System.Collections.Generic;
using System.Linq;
using _04.SULS.People;

namespace _04.SULS
{
    class SULSMain
    {
        static void Main()
        {
            // test trainer methods
            var juniorTrainer = new JuniorTrainer("Elena", "Bojilova", 24);
            var seniorTrainer = new SeniorTrainer("Filip", "Kolev", 25);
            juniorTrainer.CreateCourse("OOP");
            seniorTrainer.CreateCourse("HQC");
            seniorTrainer.DeleteCourse("OOP");
            Console.WriteLine();

            // test Reapply() method
            var applicant = new DropoutStudent("Prekusnal", "Student", 21, 1222, 3.03, "Murzi me");
            applicant.Reapply();
            Console.WriteLine();

            // Create a list of objects from each class
            var people = new List<Person>
            {
                new JuniorTrainer("Ivan", "Ivanov Jr.", 19),
                new SeniorTrainer("Ivan", "Ivanov Sr.", 45),
                new DropoutStudent("Misho", "Mihaylov", 25, 1234, 3.5, "Mrazim da mislim"),
                new GraduateStudent("Viktor", "Kazakov", 31, 1235, 5.25),
                new OnlineStudent("Elena", "Bojilova", 23, 1236, 5.75, "OOP"),
                new OnlineStudent("Pavleta", "Taseva", 21, 1237, 5.5, "OOP"),
                new OnsiteStudent("Svetlin", "Nakov", 34, 1238, 6, "OOP", 15),
            };

            // Extract only the Current Students, sort them by average grade
            var sortedCurrentStudents =
                people.Where(a => a is CurrentStudent)
                    .Cast<CurrentStudent>()
                    .OrderBy(a => a.AverageGrade);

            // printing
            Console.WriteLine("List of current students (sorted by average grade):");
            Console.WriteLine();

            foreach (var student in sortedCurrentStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
