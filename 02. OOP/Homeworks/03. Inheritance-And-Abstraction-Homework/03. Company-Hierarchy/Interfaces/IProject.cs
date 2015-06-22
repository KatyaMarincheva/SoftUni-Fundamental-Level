namespace _03.Company_Hierarchy.Interfaces
{
    using System;
    using Enums;

    interface IProject
    {
        string ProjectName { get; set; }

        DateTime ProjectStartDate { get; set; }

        string Details { get; set; }

        ProjectState ProjectState { get; }
    }
}
