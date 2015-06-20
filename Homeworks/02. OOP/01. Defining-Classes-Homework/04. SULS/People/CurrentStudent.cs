namespace _04.SULS.People
{
    using System;

    internal abstract class CurrentStudent : Student
    {
        // fields
        private string currentCourse;

        // constructor
        protected CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        // specific property
        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("currentCourse", "Current course cannot be empty.");
                }

                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "Current course: " + this.CurrentCourse + "\r\n";

            return result;
        }
    }
}
