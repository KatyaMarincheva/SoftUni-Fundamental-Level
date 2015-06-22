namespace _02.Animals.Animals
{
    using System;
    using Enums;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The kitten {0} says: Meow!", this.Name);
        }
    }
}
