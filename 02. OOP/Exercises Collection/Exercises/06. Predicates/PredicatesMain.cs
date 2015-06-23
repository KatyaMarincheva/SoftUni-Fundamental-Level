namespace _06.Predicates
{
    using System;
    using System.Collections.Generic;

    public class PredicatesMain
    {
        public static void Main()
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 6, 11, 6 };

            Console.WriteLine(collection.FirstOrDefault(x => x > 6));
            Console.WriteLine(collection.FirstOrDefault(x => x < 0));
        }
    }
}