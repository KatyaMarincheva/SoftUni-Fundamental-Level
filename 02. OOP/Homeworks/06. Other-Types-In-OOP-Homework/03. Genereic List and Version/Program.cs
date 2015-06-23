// <copyright file="Program.cs" company="Katya">
//     Katya All rights reserved.
// </copyright>
// <author>Katya</author>
namespace _03.Genereic_List_and_Version
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Displays the results from the use of the GenericList class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            // so that you can see all the entire printed list of results
            Console.BufferHeight = 200;

            var list = new GenericList<int> { 2, 3, 4, 5, 6, 7, 8, 4, 10 };
            Console.WriteLine("Initial list");
            Console.WriteLine(list);
            list.Version();
            Console.WriteLine();

            // adding an element 
            Console.WriteLine("Adding an element");
            Console.WriteLine("Adding element with value 1 to the end of the list:");
            list.Add(1);
            Console.WriteLine(list);
            Console.WriteLine();

            // accessing element by index
            Console.WriteLine("Accessing element by index");
            Console.WriteLine("The element at index {0} is {1}", 2, list[2]);
            Console.WriteLine();

            // finding element index by given value
            Console.WriteLine("Finding element index by given value");
            Console.WriteLine("The first index of {0} is {1}", 4, list.IndexOf(4));
            Console.WriteLine("The last index of {0} is {1}", 4, list.LastIndexOf(4));
            Console.WriteLine();

            // removing element by index
            Console.WriteLine("Removing element by index");
            list.RemoveAt(1);
            Console.WriteLine("Removing the element at index 1, result:");
            Console.WriteLine(list);
            Console.WriteLine();

            // removing element by value
            Console.WriteLine("Removing element by value");
            list.Remove(7);
            Console.WriteLine("Removing the element with value 7, result:");
            Console.WriteLine(list);
            Console.WriteLine();

            // inserting element at given position
            Console.WriteLine("Inserting element at given position");
            list.InsertAt(2, 8);
            Console.WriteLine("Inserted element with value 8 at index 2, result:");
            Console.WriteLine(list);
            Console.WriteLine();

            // checking if the list contains a value
            Console.WriteLine("Checking if the list contains a value");
            Console.WriteLine("Checking if the list contains an element with value 2");
            Console.WriteLine(list.Contains(2));
            Console.WriteLine("Checking if the list contains an element with value 11");
            Console.WriteLine(list.Contains(11));
            Console.WriteLine();

            // finding the minimal and maximal element in the GenericList<T>
            Console.WriteLine("Finding the minimal and maximal element in the GenericList<T>");
            Console.WriteLine("The minimal element in the GenericList is {0}", list.Min());
            Console.WriteLine("The maximal element in the GenericList is {0}", list.Max());
            Console.WriteLine();

            // clearing the list
            Console.WriteLine("Clearing the list");
            Console.WriteLine("GenericList count before clearing: {0}", list.Count);
            list.Clear();
            Console.WriteLine("GenericList count after clearing: {0}", list.Count);
            Console.WriteLine("Displaying the elements in the GenericList: {0}", list);
            Console.WriteLine();

            // adding new elements to the GenericList
            Console.WriteLine("Adding new elements to the GenericList");
            list.Add(6);
            list.Add(4);
            Console.WriteLine("GenericList: {0}", list);
            Console.WriteLine();

            System.Reflection.MemberInfo info = typeof(GenericList<>);
            foreach (object attribute in info.GetCustomAttributes(false))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
