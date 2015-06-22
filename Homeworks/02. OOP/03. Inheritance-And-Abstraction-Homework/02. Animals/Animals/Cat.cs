namespace _02.Animals.Animals
{
    using System;
    using Enums;

    abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The cat {0} says: Meow!", this.Name);
        }
    }
}
