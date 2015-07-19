// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Program_reformatted.cs" company="Katya">
// //      Katya.com. All rights reserved.
// // </copyright>
// // <summary>
// //   Reformatted version of the Program.cs file.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace _03.Genereic_List_and_Version.Program_reformatted_Files
{
    using System;
    using System.Reflection;

    /// <summary>
    ///     Reformatted version of the Program.cs file.
    /// </summary>
    public class ProgramReformatted
    {
        /// <summary>
        ///     Reformatted version of the public static void Main method.
        /// </summary>
        public static void MainReformatted()
        {
            // so that you can see the entire printed list of results
            Console.BufferHeight = 200;

            GenericListFunctionalityTest tester = GenericListFunctionalityTest.GetInstance;

            tester.TestGenericListMethods();

            PrintVersionNumber();
        }

        /// <summary>
        /// Prints the version number.
        /// </summary>
        private static void PrintVersionNumber()
        {
            MemberInfo info = typeof(GenericList<>);
            foreach (object attribute in info.GetCustomAttributes(false))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}