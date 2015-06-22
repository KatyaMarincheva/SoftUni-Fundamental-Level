namespace _03.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    interface ISalesEmployee : IEmployee
    {
        List<ISale> Sales { get; }
    }
}
