namespace _03.PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class Computer : IComparable
    {
        // fields
        private string name;
        private List<Component> components;

        // constructor
        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
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

        public List<Component> Components
        {
            get
            {
                return this.components;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("components", "Computer should contain at least one component.");
                }

                this.components = value;
            }
        }

        public decimal Price
        {
            get { return CalculateComputerPrice(this); }
        }

        // methods
        public static decimal CalculateComputerPrice(Computer computer)
        {
            var components = computer.Components;

            return components.Sum(component => component.Price);
        }

        // implementing the IComparable interface
        public int CompareTo(object obj)
        {
            var computer = (Computer)obj;
            return this.Price.CompareTo(computer.Price);
        }

        public void AddComponent(Component component)
        {
            var list = this.Components;
            list.Add(component);
            this.Components = list;
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            var description = new string('-', 50) + "\r\n";
            description += "COMPUTER DESCRIPTION\r\n";
            description += new string('-', 50) + "\r\n";
            description += "Name: " + this.Name + "\r\n";
            description += "Components:\r\n";
            description = this.Components.Aggregate(description, (current, component) => 
                current + string.Format("\t{0}{2} ({1:c2})\r\n", 
                component.Name, 
                component.Price, 
                component.Details ?? string.Empty));

            description += string.Format("Total price: {0:c2}\r\n", this.Price);
            description += new string('-', 50) + "\r\n";

            return description;
        }
    }
}
