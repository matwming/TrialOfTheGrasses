using System;

namespace leetcodesln
{
    public class SumOfSquareNumbers
    {
        public bool JudgeSquareSum(int c)
        {
            int l = 0, r = (int)Math.Sqrt(c);
            while (l <= r)
            {
                if (l * l + r * r == c) return true;
                if (l * l + r * r < c) l++;
                if (l * l + r * r > c) r--;

            }
            return false;
        }
    }
}
