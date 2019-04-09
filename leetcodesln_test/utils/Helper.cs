using System;
using System.Collections.Generic;

namespace leetcodesln_test.utils
{
    internal static class Helper<T>
    {
        public static bool HaveSameElementsForTwoCollections(IEnumerable<T> c1, IEnumerable<T> c2)
        {
            if (GetLength(c1) != GetLength(c2)) return false;

            var dict = new Dictionary<T, int>();

            var it1 = c1.GetEnumerator();
            var it2 = c2.GetEnumerator();

            while (it1.MoveNext())
            {
                if (dict.ContainsKey(it1.Current)) ++dict[it1.Current];
                else dict[it1.Current] = 1;
            }

            while (it2.MoveNext())
            {
                if (dict.ContainsKey(it2.Current))
                {
                    --dict[it2.Current];
                    if (dict[it2.Current] < 0) return false;
                }
            }
            return true;
        }

        private static int GetLength(IEnumerable<T> c)
        {
            Type type = c.GetType();

            if (type.IsAssignableFrom(typeof(List<T>)) || type.IsAssignableFrom(typeof(IList<T>))) return ((IList<T>)c).Count;
            else if (type.IsAssignableFrom(typeof(T[]))) return ((T[])c).Length;
            else throw new NotSupportedException();
        }
    }
}
