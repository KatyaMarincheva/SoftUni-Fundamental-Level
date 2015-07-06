using System;

namespace _03.String_Disperser
{
    class StringDisperserMain
    {
        public static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("katya", "pavleta", "elena");

            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }
}
