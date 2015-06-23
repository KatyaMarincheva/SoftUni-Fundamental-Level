namespace _07.Func
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public static class Func
    {
        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return Enumerable.TakeWhile(collection, element => predicate(element)).ToList();
        }
    }
}