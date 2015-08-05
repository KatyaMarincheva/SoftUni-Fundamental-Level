// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Employee interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    using _03.Company_Hierarchy.Enums;

    /// <summary>
    /// The Employee interface.
    /// </summary>
    internal interface IEmployee
    {
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        Department Department { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        decimal Salary { get; set; }
    }
}