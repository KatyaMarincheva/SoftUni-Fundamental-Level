using System.Collections.Generic;
using System.Linq;
using o;
using System.IO;

namespace Orders
{
    using Models;

    public class DataMapper
    {
        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.CategoriesFileName = categoriesFileName;
            this.ProductsFileName = productsFileName;
            this.OrdersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public string CategoriesFileName { get; set; }
        public string ProductsFileName { get; set; }
        public string OrdersFileName { get; set; }

        public IEnumerable<Category> GetAllCategories()
        {
            var cat = ReadFileLines(this.CategoriesFileName, true);
            return cat
                .Select(c => c.Split(','))
                .Select(c => new Category
                {
                    Id = int.Parse(c[0]),
                    Name = c[1],
                    Description = string.Join(", ", new List<string>(c.Skip(2).Take(c.Length - 2)))
                });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var prod = ReadFileLines(this.ProductsFileName, true);
            return prod
                .Select(p => p.Split(','))
                .Select(p => new Product
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    CategoryId = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitsInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<order> GetAllOrders()
        {
            var ord = ReadFileLines(this.OrdersFileName, true);
            return ord
                .Select(p => p.Split(','))
                .Select(p => new order
                {
                    Id = int.Parse(p[0]),
                    ProductId = int.Parse(p[1]),
                    Quantity = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        private List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}