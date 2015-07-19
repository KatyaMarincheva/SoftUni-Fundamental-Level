// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="GenericListFunctionalityTest.cs" company="Katya">
// //      Katya.com. All rights reserved.
// // </copyright>
// // <summary>
// //   Contains the GenericListFunctionalityTest() method, testing the GenericList functionality.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace _03.Genereic_List_and_Version.Program_reformatted_Files
{
    using System;

    /// <summary>
    ///     Contains the GenericListFunctionalityTest() method, testing the GenericList functionality.
    /// </summary>
    public sealed class GenericListFunctionalityTest
    {
        /// <summary>
        ///     Prevents a default instance of the <see cref="GenericListFunctionalityTest" /> class from being created.
        /// </summary>
        private GenericListFunctionalityTest()
        {
        }

        /// <summary>
        ///     Gets the get instance.
        /// </summary>
        /// <value>
        ///     Gets an instance of the GenericListFunctionalityTest class.
        /// </value>
        public static GenericListFunctionalityTest GetInstance
        {
            get { return GenericListFunctionalityTestImplementation.Instance; }
        }

        /// <summary>
        ///     Tests the generic list methods.
        /// </summary>
        public void TestGenericListMethods()
        {
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
        }

        /// <summary>
        ///     Prints the GenerisList's version number.
        /// </summary>
        private static class GenericListFunctionalityTestImplementation
        {
            /// <summary>
            ///     The instance.
            /// </summary>
            internal static readonly GenericListFunctionalityTest Instance = new GenericListFunctionalityTest();
        }
    }
}