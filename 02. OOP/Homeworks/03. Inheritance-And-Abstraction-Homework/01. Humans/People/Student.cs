using System;
using System.Text.RegularExpressions;

namespace _01.Humans.People
{
    class Student : Human
    {
        // fields
        private const string FacultyNumberMatcher = @"[a-zA-Z0-9]{5,10}";
        private string facultyNumber;

        // constructor
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        // one specific property
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (!ValidateFacultyNumber(value))
                {
                    throw new ArgumentException(
                        "Faculty number should be between 5 and 10 symbols, letters and digits only.", "facultyNumber");
                }

                this.facultyNumber = value;
            }
        }

        // methods
        public static bool ValidateFacultyNumber(string number)
        {
            return Regex.IsMatch(number, FacultyNumberMatcher);
        }

        // new override ToString(0, overriding the Human ToString()
        public override string ToString()
        {
            return base.ToString() + "\nFaculty number: " + this.FacultyNumber + "\n";
        }
    }
}
