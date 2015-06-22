namespace _03.Company_Hierarchy.Interfaces
{
    using System;

    interface ISale
    {
        string ProductName { get; set; }

        DateTime DateOfSale { get; set; }

        decimal Price { get; set; }
    }
}
