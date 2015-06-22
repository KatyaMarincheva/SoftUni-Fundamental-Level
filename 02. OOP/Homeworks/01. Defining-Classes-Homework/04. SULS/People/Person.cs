namespace _04.SULS.People
{
    using System;
    using _04.SULS.Interfaces;

    internal abstract class Person : IPerson
    {
        // fields
        private string firstName;
        private string lastName;
        private int age;

        // constructor
        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        // properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("firstName", "First name cannot be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("lastName", "Last name cannot be empty");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("age", "Age should be an integer between 0 and 100.");
                }

                this.age = value;
            }
        }

        // methods
        public override string ToString()
        {
            var result = string.Format("{1}, {0}\r\n", this.FirstName, this.LastName);
            result += "Age: " + this.Age + "\r\n";

            return result;
        }
    }
}
