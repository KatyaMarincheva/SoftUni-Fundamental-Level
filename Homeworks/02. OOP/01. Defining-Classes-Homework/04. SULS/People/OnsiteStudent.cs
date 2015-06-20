namespace _04.SULS.People
{
    using System;

    internal class OnsiteStudent : CurrentStudent
    {
        // fields
        private int numberOfVisits;

        // constructor
        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        // specific property
        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("numberOfVisits", "Number of visits cannot be negative.");
                }

                this.numberOfVisits = value;
            }
        }

        // method
        public override string ToString()
        {
            string result = base.ToString();
            result += "Number of visits: " + this.NumberOfVisits + "\r\n";

            return result;
        }
    }
}
