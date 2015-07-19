// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductOrders.Models
{
    /// <summary>
    ///     The product.
    /// </summary>
    public class Product
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
        ///     Gets or sets the category id.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        ///     Gets or sets the unit price.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        ///     Gets or sets the units in stock.
        /// </summary>
        public int UnitsInStock { get; set; }
    }
}