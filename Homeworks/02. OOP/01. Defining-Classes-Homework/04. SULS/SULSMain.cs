/* Problem 4. ** Software University Learning System
Define a class Person and the classes Trainer, Student. There are two types of trainers – Junior and Senior Trainer. 
 * There are three types of Students – Graduate, Current and Dropout Student. There are two types of Current Students – 
 * Online and Onsite Student. Implement the given structure below. A class down in the hierarchy should implement the fields, 
 * properties and methods of the classes above it. (Tip: Use Inheritance to achieve code reusability). 
 * The classes should implement the following fields/methods:
•	Person – fields first name, last name, age
o	Trainer – method CreateCourse([courseName]) that prints that the course has been created
	Senior Trainer – method DeleteCourse([courseName]) that prints that the course has been deleted
o	Student – fields student number, average grade
	Current Student – field current course
•	Onsite Student – field number of visits
	Dropout Student – field dropout reason, method Reapply() that prints all information about the student and the dropout reason
Write a class SULSTest that tests the implemented class structure. Create a list of objects from each class. 
 * Extract only the Current Students, sort them by average grade and print information about each one on the console.
Tip: Use the LINQ extension methods Where() and OrderBy() with lambda expressions.
 */

namespace _04.SULS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _04.SULS.People;

    internal class SULSMain
    {
        internal static void Main()
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
