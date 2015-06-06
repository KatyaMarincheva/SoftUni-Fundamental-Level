using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PC_Catalog
{
    class Computer : IComparable
    {
        // fields
        private string name;
        private List<Component> components;

        // constructor
        public Computer(string name, List<Component> components)
        {
            
        }

        // properties
        public string Name
        {
            get { return this.name; }
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
            get { return this.components; }
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

        // implementing the IComparable interface
        public int CompareTo(object obj)
        {
            var component = (Component)obj;
            return this.Price.CompareTo(component.Price);
        }

        public decimal CalculateComputerPrice(Computer computer)
        {
            var components = computer.Components;

            return components.Sum(component => component.Price);
        }

        public void AddComponent(Component component)
        {
            var list = this.Components;
            list.Add(component);
            this.Components = list;
        }
    }
}
