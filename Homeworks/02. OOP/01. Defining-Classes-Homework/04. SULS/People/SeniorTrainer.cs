﻿using System;

namespace _04.SULS.People
{
    class SeniorTrainer : Trainer
    {
        // constructor
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        // method
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course deleted: {0}", courseName);
        }
    }
}
