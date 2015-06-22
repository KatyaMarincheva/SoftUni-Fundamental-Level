namespace _03.Company_Hierarchy.People
{
    using System;
    using Enums;
    using Interfaces;

    abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        protected Employee(int id, string firstName, string lastName, Department department, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public Department Department { get; set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be negative.");
                }

                this.salary = value;
            }
        }
    }
}

