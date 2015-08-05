// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISale.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Sale interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _03.Company_Hierarchy.Interfaces
{
    using System;

    /// <summary>
    /// The Sale interface.
    /// </summary>
    internal interface ISale
    {
        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the date of sale.
        /// </summary>
        DateTime DateOfSale { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        decimal Price { get; set; }
    }
}