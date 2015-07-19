// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductOrdersMain.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The product orders main.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductOrders
{
    using System.Globalization;
    using System.Threading;
    using IO;

    /// <summary>
    ///     The product orders main.
    /// </summary>
    public class ProductOrdersMain
    {
        /// <summary>
        ///     The main.
        /// </summary>
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var mapper = new DataMapper();
            var categories = mapper.GetAllCategories();
            var products = mapper.GetAllProducts();
            var orders = mapper.GetAllOrders();

            // Names of the 5 most expensive products
            ConsoleRenderer.PrintMostExpensiveProducts(products, 5);

            // Number of products in each category
            ConsoleRenderer.PrintNumberOfProductsPerCategory(products, categories);

            // The 5 top products (by order quantity)
            ConsoleRenderer.PrintMostOrderedProducts(orders, products, 5);

            // The most profitable category
            ConsoleRenderer.PrintMostProfitableCategory(orders, products, categories);
        }
    }
}