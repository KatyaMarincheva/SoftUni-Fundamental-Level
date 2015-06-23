namespace _07.Func
{
    using System;
    using System.Collections.Generic;

    public class FuncMain
    {
        public static void Main()
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 6, 11, 6 };

            Console.WriteLine(string.Join(", ", collection.TakeWhile(x => x < 6)));
        }
    }
}