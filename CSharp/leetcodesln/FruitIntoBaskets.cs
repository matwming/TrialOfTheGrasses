using System.Collections.Generic;

namespace leetcodesln
{
    public class FruitIntoBaskets
    {
        public int TotalFruit(int[] tree)
        {
            var dict = new Dictionary<int, int>();
            int l = 0, r = 0;
            while (r < tree.Length)
            {
                if (dict.ContainsKey(tree[r]))
                {
                    dict[tree[r]]++;
                }
                else
                {
                    dict.Add(tree[r], 1);
                }
                if (dict.Count > 2)
                {
                    if (--dict[tree[l]] == 0) dict.Remove(tree[l]);
                    l++;
                }
                r++;
            }
            return r - l;
        }
    }
}
