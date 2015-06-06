using System;
using System.Runtime.InteropServices;

namespace _02.LaptopShop
{
    public class Laptop
    {
        // fields
        private string model;
        private decimal price;

        // constructors
        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd,
            string screen, Battery laptopBattery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.LaptopBattery = laptopBattery;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string hdd,
            string screen, decimal price)
                : this(model, manufacturer, processor, ram, null, hdd,
                screen, null, price)
        {

        }

        public Laptop(string model, string manufacturer, string screen, decimal price)
            : this(model, manufacturer, null, null, null, null,
            screen, null, price)
        {

        }

        public Laptop(string model, decimal price)
            : this(model, null, null, null, null, null,
            null, null, price)
        {

        }

        // properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("model", "Model info cannot be empty.");
                }
                this.model = value;
            }
        }

        public string Manufacturer { get; set; }

        public string Processor { get; set; }

        public string RAM { get; set; }

        public string GraphicsCard { get; set; }

        public string HDD { get; set; }

        public string Screen { get; set; }

        public Battery LaptopBattery { get; set; }

        public decimal Price
        {
            get { return this.price; }
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
        public override string ToString()
        {
            string description = new string('-', 85) + "\r\n";
            description += string.Format("|{0}|\r\n", "laptop description".PadLeft(((83 - "laptop description".Length) / 2)
                                + "laptop description".Length).PadRight(83));
            description += new string('-', 85) + "\r\n";

            description += string.Format("{0, -15}| {1, 66} |\r\n", "| model", this.Model);
            description += new string('-', 85) + "\r\n";

            if (!string.IsNullOrWhiteSpace(this.Manufacturer))
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| manufacturer", this.Manufacturer);
                description += new string('-', 85) + "\r\n";
            }

            if (!string.IsNullOrWhiteSpace(this.Processor))
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| processor", this.Processor);
                description += new string('-', 85) + "\r\n";
            }

            if (!string.IsNullOrWhiteSpace(this.RAM))
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| RAM", this.RAM);
                description += new string('-', 85) + "\r\n";
            }

            if (!string.IsNullOrWhiteSpace(this.GraphicsCard))
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| graphics card", this.GraphicsCard);
                description += new string('-', 85) + "\r\n";
            }

            if (!string.IsNullOrWhiteSpace(this.HDD))
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| HDD", this.HDD);
                description += new string('-', 85) + "\r\n";
            }

            if (!string.IsNullOrWhiteSpace(this.Screen))
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| screen", this.Screen);
                description += new string('-', 85) + "\r\n";
            }

            if (this.LaptopBattery != null)
            {
                description += string.Format("{0, -15}| {1, 66} |\r\n", "| battery", this.LaptopBattery);
                description += new string('-', 85) + "\r\n";
                description += string.Format("{0, -15}| {1, 60:f1} hours |\r\n", "| battery life", this.LaptopBattery.BatteryLife);
                description += new string('-', 85) + "\r\n";
            }

            description += string.Format("{0, -15}| {1, 66:c2} |\r\n", "| price", this.Price);
            description += new string('-', 85) + "\r\n\r\n";

            return description;
        }
    }
}
