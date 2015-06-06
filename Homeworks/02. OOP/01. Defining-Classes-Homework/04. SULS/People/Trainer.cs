using System;
using _04.SULS.Interfaces;

namespace _04.SULS.People
{
    abstract class Trainer : Person, ITrainer
    {
        // constructor
        protected Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        // method
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course created: {0}", courseName);
        }
    }
}
