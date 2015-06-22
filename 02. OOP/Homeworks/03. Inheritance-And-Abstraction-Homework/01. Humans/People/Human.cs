using System;
using _01.Humans.Interfaces;

namespace _01.Humans.People
{
    abstract class Human : IHuman
    {
        // fields
        private string firstName;
        private string lastName;

        // constructor
        protected Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
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
                    throw new ArgumentNullException("firstName", "Name cannot be empty");
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
                    throw new ArgumentNullException("lastName", "Name cannot be empty");
                }

                this.lastName = value;
            }
        }

        // methods
        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}
