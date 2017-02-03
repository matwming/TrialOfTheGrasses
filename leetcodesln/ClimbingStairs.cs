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

            return ClimbStairsSln(n - 1) + ClimbStairsSln(n - 2);
        }
    }
}
