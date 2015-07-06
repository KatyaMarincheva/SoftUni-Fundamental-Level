namespace _02.Customer
{
    using System;
    using System.Linq;

    class CustomerMain
    {
        static void Main()
        {
            Payment hdd = new Payment("WD HDD 2TB", 189.99m);
            Payment mouse = new Payment("Mouse", 9.90m);
            Customer geek = new Customer("Bill", "Gates", 8712013812, Enum.CustomerType.Diamond, hdd, mouse);

            Payment vacation = new Payment("Vacation", 1250);
            Customer smart = new Customer("Katya", "Georgieva", "Tomova", 9203131111, Enum.CustomerType.OneTime, "Sofia", null, null, vacation);

            Customer geekCopy = (Customer)geek.Clone();
            geek.AddNewPayment(vacation);
            Console.WriteLine(geek);
            Console.WriteLine(geekCopy);

            Console.WriteLine(geek == smart);
            Console.WriteLine(geek == geekCopy);
            Console.WriteLine(Customer.Equals(geek, geekCopy));
            Console.WriteLine();

            Customer[] customers = new[] { geek, geekCopy, smart };
            Array.Sort(customers);
            Console.WriteLine(string.Join("\n", customers.ToList()));
        }
    }
}
