namespace _02.Animals.Animals
{
    using System;
    using Enums;

    class TomCat : Cat
    {
        public TomCat(string name, int age)
            : base(name, age, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The tomcat {0} says: Meow!", this.Name);
        }
    }
}
