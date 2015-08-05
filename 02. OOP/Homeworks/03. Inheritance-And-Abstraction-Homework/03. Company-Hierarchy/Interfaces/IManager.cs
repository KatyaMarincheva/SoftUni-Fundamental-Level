// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IManager.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Manager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// The Manager interface.
    /// </summary>
    internal interface IManager : IEmployee
    {
        /// <summary>
        /// Gets the employees managed.
        /// </summary>
        List<IEmployee> EmployeesManaged { get; }
    }
}