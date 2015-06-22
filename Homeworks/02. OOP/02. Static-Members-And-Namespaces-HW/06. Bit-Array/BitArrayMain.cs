using System;

namespace _06.Bit_Array
{
    class BitArrayTest
    {
        static void Main()
        {
            BitArray test = new BitArray(32);
            Console.WriteLine(test[5]);
            test[5] = 1;
            Console.WriteLine(test[5]);
            Console.WriteLine(test);

            BitArray max = new BitArray(100000);
            max[99999] = 1;
            Console.WriteLine(max);
            Console.WriteLine(max & test);
        }
    }
}
