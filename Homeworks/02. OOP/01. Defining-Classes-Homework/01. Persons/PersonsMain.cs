using System;

namespace _01.Persons
{
    public class PersonsMain
    {
        static void Main()
        {
            // 1st test option:
            // You can run the Unit Tests from the Visual Studio menu: 
            // BUILD -> Build Solution
            // TEST -> Windows -> Test Explorer (you will see in the Test Explorer window: Not Run Tests (7)
            // and above it:  Run All
            // Please, click on Run All, and read the ClassPersonTests.cs file for more details

            // 2nd test option: input
            Console.Write("Please, enter a name: ");
            var name = Console.ReadLine();
            Console.Write("Please, enter a a value for age: ");
            var age = ReadAge(); // validates integer input
            Console.Write("Please, enter an email: ");
            var email = Console.ReadLine();

            // try to create a person with the above input data - 
            // bug ?, if you uncomment both person1 and person2 below, one single input will create 2 persons instead of one
            try
            {
                var person1 = new Person(name, age);
                Console.WriteLine(person1);

                //var person2 = new Person(name, age, email);
                //Console.WriteLine(person2);
            }
            catch (Exception e) // check for exceptions - in case of multipple exceptions, only the first one is displayed
            {
                Console.WriteLine("Error: {0}\n{1}", e.GetType(), e.Message);
            }
        }

        public static int ReadAge()
        {
            var input = Console.ReadLine();

            try
            {
                var num = int.Parse(input);              

                return num;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}\n{1}", e.GetType(), e.Message);
                Console.Write("Please enter a number: ");
                return ReadAge();
            }
        }
    }
}
