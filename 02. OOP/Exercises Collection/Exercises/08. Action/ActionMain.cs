namespace _08.Action
{
    using System;
    using System.Collections.Generic;

    public class ActionMain
    {
        public static void Main()
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 6, 11, 6 };

            collection.ForEach(Console.WriteLine);
        }
    }
}