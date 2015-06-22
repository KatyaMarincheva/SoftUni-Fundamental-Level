namespace _03.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    interface IDeveloper : IEmployee
    {
        List<IProject> Projects { get; }
    }
}
