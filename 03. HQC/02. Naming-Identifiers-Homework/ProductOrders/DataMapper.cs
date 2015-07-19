// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataMapper.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The data mapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductOrders
{
    using System.Collections.Generic;
    using System.Linq;
    using IO;
    using Models;

    /// <summary>
    ///     The data mapper.
    /// </summary>
    public class DataMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMapper"/> class.
        /// </summary>
        /// <param name="categoriesFileName">
        /// The categories file name.
        /// </param>
        /// <param name="productsFileName">
        /// The products file name.
        /// </param>
        /// <param name="ordersFileName">
        /// The orders file name.
        /// </param>
        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.CategoriesFileName = categoriesFileName;
            this.ProductsFileName = productsFileName;
            this.OrdersFileName = ordersFileName;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DataMapper" /> class.
        /// </summary>
        public DataMapper()
            : this(
                "../../DatabaseFiles/categories.txt", 
                "../../DatabaseFiles/products.txt", 
                "../../DatabaseFiles/orders.txt")
        {
        }

        /// <summary>
        ///     Gets or sets the categories file name.
        /// </summary>
        public string CategoriesFileName { get; set; }

        /// <summary>
        ///     Gets or sets the products file name.
        /// </summary>
        public string ProductsFileName { get; set; }

        /// <summary>
        ///     Gets or sets the orders file name.
        /// </summary>
        public string OrdersFileName { get; set; }

        /// <summary>
        ///     The get all categories.
        /// </summary>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        public IEnumerable<Category> GetAllCategories()
        {
            var categoryArgs = InputHandler.ReadFileLines(this.CategoriesFileName, true);
            return
                categoryArgs.Select(c => c.Split(','))
                    .Select(
                        c =>
                            new Category
                            {
                                Id = int.Parse(c[0]), 
                                Name = c[1], 
                                Description = string.Join(", ", new List<string>(c.Skip(2).Take(c.Length - 2)))
                            });
        }

        /// <summary>
        ///     The get all products.
        /// </summary>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        public IEnumerable<Product> GetAllProducts()
        {
            var products = InputHandler.ReadFileLines(this.ProductsFileName, true);
            return
                products.Select(productString => productString.Split(','))
                    .Select(
                        product =>
                            new Product
                            {
                                Id = int.Parse(product[0]), 
                                Name = product[1], 
                                CategoryId = int.Parse(product[2]), 
                                UnitPrice = decimal.Parse(product[3]), 
                                UnitsInStock = int.Parse(product[4])
                            });
        }

        /// <summary>
        ///     The get all orders.
        /// </summary>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        public IEnumerable<Order> GetAllOrders()
        {
            var orders = InputHandler.ReadFileLines(this.OrdersFileName, true);
            return
                orders.Select(orderString => orderString.Split(','))
                    .Select(
                        order =>
                            new Order
                            {
                                Id = int.Parse(order[0]), 
                                ProductId = int.Parse(order[1]), 
                                Quantity = int.Parse(order[2]), 
                                Discount = decimal.Parse(order[3])
                            });
        }
    }
}