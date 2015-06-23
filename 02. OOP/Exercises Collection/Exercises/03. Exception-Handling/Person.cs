namespace _03.Exception_Handling
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "The first name cannot be null or empty");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "The last name cannot be null or empty.");
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
                if (value < 0 || 120 < value)
                {
                    throw new ArgumentOutOfRangeException("age", "Age should be in the range [0 ... 120].");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}