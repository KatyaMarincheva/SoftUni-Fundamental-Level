namespace _08.Action
{
    using System;
    using System.Collections.Generic;

    public static class Action
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }
        }
    }
}
