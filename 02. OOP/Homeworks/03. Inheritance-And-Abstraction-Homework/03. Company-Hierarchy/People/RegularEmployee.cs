namespace _03.Company_Hierarchy.People
{
    using Enums;

    abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(int id, string firstName, string lastName, Department department, decimal salary)
            : base(id, firstName, lastName, department, salary)
        {
        }
    }
}
