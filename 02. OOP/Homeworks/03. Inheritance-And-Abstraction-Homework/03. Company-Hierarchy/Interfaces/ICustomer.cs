namespace _03.Company_Hierarchy.Interfaces
{
    interface ICustomer : IPerson
    {
        decimal NetSpendingAmount { get; set; }
    }
}
