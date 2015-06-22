namespace _02.Animals.Animals
{
    using System;
    using Enums;

    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The dog {0} says: Woof", this.Name);
        }
    }
}
