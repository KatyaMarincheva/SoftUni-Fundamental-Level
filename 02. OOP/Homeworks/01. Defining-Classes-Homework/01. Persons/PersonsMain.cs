/* Problem 1. Persons
Define a class Person that has name, age and email. The name and age are mandatory. The email is optional. 
 * Define properties that accept non-empty name and age in the range [1 ... 100]. In case of invalid arguments, 
 * throw an exception. Define a property for the email that accepts either null or non-empty string containing '@'. 
 * Define two constructors. The first constructor should take name, age and email. 
 * The second constructor should take name and age only and call the first constructor. 
 * Implement the ToString() method to enable printing persons at the console.
 */

namespace _01.Persons
{
    using System;

    public class PersonsMain
    {
        public static void Main()
        {
            // 1st test option:
            // You can run the Unit Tests from the Visual Studio menu: 
            // BUILD -> Build Solution
            // TEST -> Windows -> Test Explorer (you will see in the Test Explorer window: Not Run Tests or Passed Tests
            // and above it:  Run All
            // Please, click on Run All, and read the ClassPersonTests.cs file for more details

            // 2nd test option: input
            Console.Write("Please, enter a name: ");
            var name = Console.ReadLine();
            Console.Write("Please, enter a a value for age: ");
            var age = ReadAge(); // validates integer input
            Console.Write("Please, enter an email: ");
            var email = Console.ReadLine();

            // try to create a person with the above input data
            // check for exceptions - in case of multipple exceptions, only the first one is displayed
            try
            {
                if (email != string.Empty)
                {
                    var person1 = new Person(name, age);
                    Console.WriteLine(person1);
                }

                var person2 = new Person(name, age, email);
                Console.WriteLine(person2);
            }
            catch (Exception e) 
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
