namespace _04.SULS.People
{
    using System;
    using _04.SULS.Interfaces;

    internal abstract class Student : Person, IStudent
    {
        // fields
        private int studentNumber;
        private double averageGrade;

        // constructor
        protected Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        // properties
        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            set
            {
                if (value < 1000 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("studentNumber", "Student number should be in the range [1000 ... 10000].");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("averageGrade", "Average grade should be in the range [2 ... 6].");
                }

                this.averageGrade = value;
            }
        }

        // method
        public override string ToString()
        {
            var result = base.ToString();
            result += "Student number: " + this.StudentNumber + "\r\n";
            result += string.Format("Average grade: {0:f2}\r\n", this.AverageGrade);

            return result;
        }
    }
}
