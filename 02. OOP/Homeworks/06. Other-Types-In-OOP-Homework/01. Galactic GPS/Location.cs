namespace _01.Galactic_GPS
{
    using System;
    using System.Device.Location;

    internal struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                if (value < -90.0 || value > 90.0)
                {
                    throw new ArgumentOutOfRangeException("latitude", "Invalid latitude, please choose a value between [-90...90]");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                if (value < -180.0 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("longitude", "Inalid latitude, please choose a value between [-180...180]");
                }

                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public double GetDistance(Location other)
        {
            var firstCordinate = new GeoCoordinate(this.Latitude, this.Longitude);
            var secondCordinate = new GeoCoordinate(other.Latitude, other.Longitude);

            double distance = firstCordinate.GetDistanceTo(secondCordinate);
            return distance;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}