namespace _09.Country
{
    using System;
    using System.Collections.Generic;

    public class Country : ICloneable, IComparable<Country>
    {
        private string name;
        private long population;
        private decimal area;

        public Country(string name, long population, decimal area)
        {
            this.Name = name;
            this.Population = population;
            this.Area = area;
        }

        public Country(string name, long population, decimal area, HashSet<string> cities)
            : this(name, population, area)
        {
            this.Cities = cities;
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public long Population
        {
            get
            {
                return this.population;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("population", "Population cannot be negative.");
                }

                this.population = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.area;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("area", "Area cannot be negative.");
                }

                this.area = value;
            }
        }

        public HashSet<string> Cities { get; set; }

        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Country country = param as Country;
            // Country country = (Country)param;

            // Check if we have valid not null Student object
            if (Object.Equals(country, null)) //if (Object.Equals(a,null) || Object.Equals(b,null))
            {
                return false;
            }

            // Compare the reference type member fields
            if (Object.Equals(this.Name, country.Name))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public static bool operator ==(Country a, Country b)
        {
            if (Object.Equals(a, null) || Object.Equals(b, null))
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(Country a, Country b)
        {
            if (Object.Equals(a,null) || Object.Equals(b,null))
            {
                return false;
            }

            return !a.Equals(b);
        }

        public object Clone()
        {
            return new Country("x", 1, 1)
            {
                Name = this.Name,
                Population = this.Population,
                Area = this.Area,
                Cities = new HashSet<string>(this.Cities)
            };
        }

        public override string ToString()
        {
            string output = string.Format(
                "{0}: population: {1}, area: {2}", 
                this.Name, 
                this.Population, 
                this.Area);

            if (this.Cities != null)
            {
                output += string.Format(", cities: {0}", string.Join(", ", this.Cities));
            }

            return output;
        }

        public int CompareTo(Country other)
        {
            if (this.Area < other.Area)
            {
                return 1;
            }
            if (this.Area > other.Area)
            {
                return -1;
            }
            if (this.Population < other.Population)
            {
                return 1;
            }
            if (this.Population > other.Population)
            {
                return -1;
            }
            if (this.Name.CompareTo(other.Name) > 0)
            {
                return 1;
            }
            if (this.Name.CompareTo(other.Name) < 0)
            {
                return -1;
            }
            if (this.Name.CompareTo(other.Name) == 0)
            {
                return 0;
            }
            return 0;
        }
    }
}
