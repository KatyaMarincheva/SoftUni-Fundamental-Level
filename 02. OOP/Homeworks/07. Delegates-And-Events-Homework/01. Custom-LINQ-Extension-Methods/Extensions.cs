namespace _01.Custom_LINQ_Extension_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        // filters elements NOT matching the chosen criterion
        public static IEnumerable<T> WhereNot<T>(
    this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(element => !predicate(element)).ToList();
        }

        // returns the max value of the chosen element property in a collection of elements
        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criterion) where TSelector : IComparable<TSelector>
        {
            TSelector max = criterion(collection.First());

            foreach (var item in collection.Where(item => max.CompareTo(criterion(item)) < 0))
            {
                max = criterion(item);
            }

            return max;
        }

        // returns the min value of the chosen element property in a collection of elements
        public static TSelector Min<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criterion) where TSelector : IComparable<TSelector>
        {
            TSelector min = criterion(collection.First());

            foreach (var item in collection.Where(item => min.CompareTo(criterion(item)) > 0))
            {
                min = criterion(item);
            }

            return min;
        }

        // returns the Max element in a collection of elements (max -min order is defined by a separate criterion Func)
        public static TSource MaxStudent<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criterion) where TSelector : IComparable<TSelector>
        {
            return collection.OrderByDescending(criterion).First();
        }

        // returns the Min element in a collection of elements (max -min order is defined by a separate criterion Func)
        public static TSource MinStudent<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criterion) where TSelector : IComparable<TSelector>
        {
            return collection.OrderBy(criterion).First();
        }
    }
}
