using leetcodesln.common;
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

        public static bool HaveSameInorderSequenceForTwoTreeNodes(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null || node1 == node2) return true;

            var s1 = new Stack<TreeNode>();
            var s2 = new Stack<TreeNode>();
            var curr1 = node1;
            var curr2 = node2;

            try
            {
                while ((curr1 != null || s1.Count != 0) && (curr2 != null || s2.Count != 0))
                {
                    while (curr1 != null || curr2 != null)
                    {
                        s1.Push(curr1);
                        curr1 = curr1.left;
                        s2.Push(curr2);
                        curr2 = curr2.left;
                    }
                    curr1 = s1.Peek();
                    curr2 = s2.Peek();
                    s1.Pop();
                    s2.Pop();

                    if (curr1.val != curr2.val) return false;

                    curr1 = curr1.right;
                    curr2 = curr2.right;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private static int GetLength(IEnumerable<T> c)
        {
            Type type = c.GetType();

            //if (type.IsAssignableFrom(typeof(List<T>)) || type.IsAssignableFrom(typeof(IList<T>))) return ((IList<T>)c).Count;
            if (c is List<T> l) return l.Count;
            //else if (type.IsAssignableFrom(typeof(T[]))) return ((T[])c).Length;
            else if (c is T[] t) return t.Length;
            else throw new NotSupportedException($"The collection type: {type.Name} is not supported.");
        }
    }
}
