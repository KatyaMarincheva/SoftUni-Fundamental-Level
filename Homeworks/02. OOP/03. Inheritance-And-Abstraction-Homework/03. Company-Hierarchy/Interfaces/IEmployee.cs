namespace _03.Company_Hierarchy.Interfaces
{
    using Enums;

    interface IEmployee
    {
        Department Department { get; set; }

        decimal Salary { get; set; }
    }
}
