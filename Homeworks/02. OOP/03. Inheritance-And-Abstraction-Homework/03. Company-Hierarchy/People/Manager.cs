namespace _03.Company_Hierarchy.People
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, Department department, decimal salary, List<IEmployee> employeesManaged)
            : base(id, firstName, lastName, department, salary)
        {
            this.EmployeesManaged = employeesManaged;
        }

        public Manager(int id, string firstName, string lastName, Department department, decimal salary, IEmployee employeeManaged)
            : this(id, firstName, lastName, department, salary, new List<IEmployee> { employeeManaged })
        {
        }

        public List<IEmployee> EmployeesManaged { get; private set; }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Manager\n");
            result += string.Format("Employees managed: ");

            List<string> employeeNames = new List<string>();
            foreach (Employee employee in this.EmployeesManaged)
            {
                employeeNames.Add(string.Format("{0} {1}", employee.FirstName, employee.LastName));
            }

            result += string.Join(", ", employeeNames) + "\n";

            return result;
        }
    }
}
