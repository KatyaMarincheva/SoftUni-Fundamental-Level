// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISalesEmployee.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The SalesEmployee interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// The SalesEmployee interface.
    /// </summary>
    internal interface ISalesEmployee : IEmployee
    {
        /// <summary>
        /// Gets the sales.
        /// </summary>
        List<ISale> Sales { get; }
    }
}