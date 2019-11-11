using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 0) return 0;

            var res = 0;
            int pre1 = 1, pre2 = 2;
            for (int i = 3; i <= n; i++)
            {
                res = pre1 + pre2;
                pre1 = pre2;
                pre2 = res;
            }
            return res;
        }
    }
}
