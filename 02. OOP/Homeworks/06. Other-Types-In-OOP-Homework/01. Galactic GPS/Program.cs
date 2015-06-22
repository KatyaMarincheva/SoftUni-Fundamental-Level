namespace _01.Galactic_GPS
{
    using System;

    internal class Program
    {
        internal static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Location partyPlace = new Location(25.42378, 75.53248, Planet.Uranus);

            double distance = home.GetDistance(partyPlace);

            Console.WriteLine("The distance between \n{0} and \n{1} \nis {2:F2}km", home, partyPlace, distance / 1000);
        }
    }
}
