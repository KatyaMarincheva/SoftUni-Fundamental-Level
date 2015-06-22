namespace _03.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    interface IManager : IEmployee
    {
        List<IEmployee> EmployeesManaged { get; }
    }
}
