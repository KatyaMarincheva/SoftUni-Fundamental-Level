namespace _02.LaptopShop
{
    using System;

    public class Battery
    {
        // fields
        private string type;
        private int numberOfCells;
        private int capacity;
        private double batteryLife;

        // constructor
        public Battery(string type, int numberOfCells, int capacity, double batteryLife)
        {
            this.Type = type;
            this.NumberOfCells = numberOfCells;
            this.Capacity = capacity;
            this.BatteryLife = batteryLife;
        }

        // properties
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("type", "Type info cannot be empty.");
                }

                this.type = value;
            }
        }

        public int NumberOfCells
        {
            get
            {
                return this.numberOfCells;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("numberOfCells", "The number of cells cannot be negative.");
                }

                this.numberOfCells = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("capacity", "The capacity cannot be negative.");
                }

                this.capacity = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("batteryLife", "The battery life cannot be negative");
                }

                this.batteryLife = value;
            }
        }

        // methods
        public override string ToString()
        {
            return string.Format(
                "{0}, {1}-cells, {2} mAh",
                this.Type, 
                this.NumberOfCells, 
                this.Capacity);
        }
    }
}
