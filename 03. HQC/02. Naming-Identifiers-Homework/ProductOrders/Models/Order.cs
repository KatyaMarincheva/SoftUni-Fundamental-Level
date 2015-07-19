// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Order.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The order.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductOrders.Models
{
    /// <summary>
    ///     The order.
    /// </summary>
    public class Order
    {
        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        ///     Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        ///     Gets or sets the discount.
        /// </summary>
        public decimal Discount { get; set; }
    }
}