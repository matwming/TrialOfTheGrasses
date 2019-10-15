using System;

namespace leetcodesln
{
    public class MaxConsecutiveOnesIII
    {
        public int LongestOnes(int[] a, int k)
        {
            int l = 0, r = 0, ans = 0;
            for (; r < a.Length; ++r)
            {
                if (a[r] == 0)
                {
                    k--;
                    while (k < 0)
                    {
                        if (a[l] == 1) l++;
                        else
                        {
                            k++;
                            l++;
                        }
                    }
                }
                ans = Math.Max(ans, r - l + 1);
            }
            return ans;
        }
    }
}
