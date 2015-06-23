namespace Battleships.Ships
{
    using System;

    public class AircraftCarrier : Ship
    {
        private string name;
        private double lengthInMeters;
        private double volume;
        private int fighterCapacity;

        public AircraftCarrier(string name, double lengthInMeters, double volume, int fighterCapacity)
        {
            this.Name = name;
            this.LengthInMeters = lengthInMeters;
            this.Volume = volume;
            this.FighterCapacity = fighterCapacity;
            this.IsBattleship = true;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public double LengthInMeters
        {
            get
            {
                return this.lengthInMeters;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of a ship cannot be negative.");
                }

                this.lengthInMeters = value;
            }
        }

        public double Volume
        {
            get
            {
                return this.volume;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The volume of a ship cannot be negative.");
                }

                this.volume = value;
            }
        }

        public int FighterCapacity
        {
            get
            {
                return this.fighterCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
                }

                this.fighterCapacity = value;
            }
        }

        public void Attack(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
    }
}
