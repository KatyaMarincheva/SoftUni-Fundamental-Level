// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDeveloper.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Developer interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// The Developer interface.
    /// </summary>
    internal interface IDeveloper : IEmployee
    {
        /// <summary>
        /// Gets the projects.
        /// </summary>
        List<IProject> Projects { get; }
    }
}