namespace _03.PC_Catalog
{
    using System;

    public class Component : IComparable
    {
        // fields
        private string name;
        private decimal price;

        // constructors
        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component(string name, decimal price)
            : this(name, price, null)
        {           
        }

        // properties
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be empty");
                }

                this.name = value;
            }
        }

        public string Details { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be negative.");
                }

                this.price = value;
            }
        }

        // methods
        // implementing the IComparable interface
        public int CompareTo(object obj)
        {
            var component = (Component)obj;
            return this.Price.CompareTo(component.Price);
        }
    }
}
