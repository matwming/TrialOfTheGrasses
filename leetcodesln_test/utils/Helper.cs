using System.Collections.Generic;

namespace leetcodesln_test.utils
{
    internal static class Helper<T>
    {
        public static bool HaveSameElementsForTwoArray(T[] arr1, T[] arr2)
        {
            if (arr1.Length != arr2.Length) return false;

            var dict1 = new Dictionary<T, int>();
            var dict2 = new Dictionary<T, int>();

            foreach (var item in arr1)
            {
                if (dict1.ContainsKey(item)) ++dict1[item];
                else dict1[item] = 1;
            }

            foreach (var item in arr2)
            {
                if (dict2.ContainsKey(item)) ++dict2[item];
                else dict2[item] = 1;
            }

            foreach (var item in dict2)
            {
                if (item.Value != dict1.GetValueOrDefault(item.Key)) return false;
            }
            return true;
        }
    }
}
