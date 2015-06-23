namespace Battleships.Ships
{
    using System;

    public class Destroyer : Ship
    {
        private string name;
        private double lengthInMeters;
        private double volume;
        private int numberOfAmmunition;

        public Destroyer(string name, double lengthInMeters, double volume, int numberOfAmmunition)
        {
            this.Name = name;
            this.LengthInMeters = lengthInMeters;
            this.Volume = volume;
            this.NumberOfAmmunition = numberOfAmmunition;
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

        public int NumberOfAmmunition
        {
            get
            {
                return this.numberOfAmmunition;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The number of ammunition in a destroyer cannot be negative.");
                }

                this.numberOfAmmunition = value;
            }
        }

        public void Attack(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
    }
}
