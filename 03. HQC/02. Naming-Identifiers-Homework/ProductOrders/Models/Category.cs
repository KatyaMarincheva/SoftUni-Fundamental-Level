// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductOrders.Models
{
    /// <summary>
    ///     The category.
    /// </summary>
    public class Category
    {
        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}