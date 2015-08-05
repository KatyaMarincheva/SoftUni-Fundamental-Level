// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProject.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Project interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    using System;

    using _03.Company_Hierarchy.Enums;

    /// <summary>
    /// The Project interface.
    /// </summary>
    internal interface IProject
    {
        /// <summary>
        /// Gets or sets the project name.
        /// </summary>
        string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the project start date.
        /// </summary>
        DateTime ProjectStartDate { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        string Details { get; set; }

        /// <summary>
        /// Gets the project state.
        /// </summary>
        ProjectState ProjectState { get; }
    }
}