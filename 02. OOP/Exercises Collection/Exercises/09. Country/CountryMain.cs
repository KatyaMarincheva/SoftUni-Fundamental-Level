namespace _09.Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountryMain
    {
        public static void Main()
        {
            Country bg = new Country("Bulgaria", 7100000, 111000, new HashSet<string> { "Sofia", "Plovdiv", "Varna" });
            Country usa = new Country("USA", 300000000, 1200000, new HashSet<string> { "New York", "Los Angeles", "San Francisco" });
            Country bg2 = new Country("Bulgaria", 8000000, 10);
            Country bg3 = new Country("Bulgaria", 8000000, 111000);
            Country hr = new Country("Croatia", 8000000, 111000);

            // cloning coutries
            var bgCopy = bg.Clone() as Country;
            bg.Cities.Add("Kaspichan");

            Console.WriteLine("bg cities: {0}", string.Join(", ", bg.Cities));
            Console.WriteLine("bgCopy cities: {0}", string.Join(", ", bgCopy.Cities));

            // comparing HashCodes
            Console.WriteLine("bg.GetHashCode() = {0}", bg.GetHashCode());
            Console.WriteLine("bg2.GetHashCode() = {0}", bg2.GetHashCode());
            
            // comparing countries
            Console.WriteLine("bg.CompareTo(bgCopy): {0}", bg.CompareTo(bgCopy));
            Console.WriteLine("bg.CompareTo(usa): {0}", bg.CompareTo(usa));

            Console.WriteLine(bg.Equals(bg2));
            Console.WriteLine(Country.Equals(hr, bg));
            Console.WriteLine(bg == bg2); // True
            Console.WriteLine(bg == usa); // False
            Console.WriteLine(bg != bg2); // False
            Console.WriteLine(bg != usa); // True

            // sorting coutries
            var countries = new List<Country> { bg, usa, bg2, bg3, hr };
            countries.Sort();

            Console.WriteLine(
                string.Join(Environment.NewLine, countries
                    .Select(c => new { c.Name, c.Area, c.Population })));

            Console.WriteLine(string.Join(Environment.NewLine, countries));
        }
    }
}
