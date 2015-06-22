namespace _04.SULS.People
{
    using System;

    internal class DropoutStudent : Student
    {
        // fields
        private string dropoutReason;

        // constructor
        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        // specific property
        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("dropoutReason", "Dropout reason cannot be empty.");
                }

                this.dropoutReason = value;
            }
        }

        // methods
        public void Reapply()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "Dropout reason: " + this.DropoutReason + "\r\n";

            return result;
        }
    }
}
