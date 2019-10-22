using System.Collections.Generic;

namespace leetcodesln
{
    public class FourSumII
    {
        public int FourSumCount(int[] a, int[] b, int[] c, int[] d)
        {
            int ans = 0;
            var ab = new Dictionary<int, int>();
            var cd = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < b.Length; ++j)
                {
                    var sum = a[i] + b[j];
                    if (ab.ContainsKey(sum)) ab[sum]++;
                    else ab.Add(sum, 1);
                }
            }

            for (int i = 0; i < c.Length; ++i)
            {
                for (int j = 0; j < d.Length; ++j)
                {
                    var sum = c[i] + d[j];
                    if (cd.ContainsKey(sum)) cd[sum]++;
                    else cd.Add(sum, 1);
                }
            }

            foreach (var kv in ab)
            {
                var complement = 0 - kv.Key;
                if (cd.ContainsKey(complement))
                {
                    ans += (kv.Value * cd[complement]);
                }
            }
            return ans;
        }
    }
}
