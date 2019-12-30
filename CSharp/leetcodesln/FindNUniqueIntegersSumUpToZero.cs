using System;
using System.Linq;

namespace leetcodesln
{
    public class FindNUniqueIntegersSumUpToZero
    {
        public int[] SumZero(int n)
        {
            if (n == 1) return new[] { 0 };

            var rnd = new Random();
            var ans = new int[n];
            var i = 0;
            if (n % 2 != 0)
            {
                ans[i++] = 0;
            }

            int? num = null;
            while (i < ans.Length)
            {
                do num = rnd.Next();
                while (ans.Contains(num.Value));
                ans[i++] = num.Value;
                ans[i++] = -num.Value;
            }
            return ans;
        }
    }
}
