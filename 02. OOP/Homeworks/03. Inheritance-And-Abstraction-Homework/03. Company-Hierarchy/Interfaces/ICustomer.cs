// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICustomer.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Customer interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    /// <summary>
    /// The Customer interface.
    /// </summary>
    internal interface ICustomer : IPerson
    {
        /// <summary>
        /// Gets or sets the net spending amount.
        /// </summary>
        decimal NetSpendingAmount { get; set; }
    }
}