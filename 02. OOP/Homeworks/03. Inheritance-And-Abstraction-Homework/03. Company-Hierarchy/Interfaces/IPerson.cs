// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPerson.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Person interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    /// <summary>
    /// The Person interface.
    /// </summary>
    internal interface IPerson
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        string LastName { get; set; }
    }
}