using System;

namespace leetcodesln
{
    public class RangeSumQuery_Immutable
    {
        private int[] _nums { get; set; }

        public RangeSumQuery_Immutable(int[] nums)
        {
            _nums = nums;
        }

        public int SumRange(int i, int j)
        {
            if (i == j) return _nums[i];

            var dp = new int[_nums.Length + 1];
            Array.Fill(dp, int.MinValue);
            dp[0] = 0;

            return GetZeroToIndex(ref dp, j + 1) - GetZeroToIndex(ref dp, i);
        }

        private int GetZeroToIndex(ref int[] dp, int i)
        {

            if (dp[i] != int.MinValue) return dp[i];
            else
            {
                var sum = 0;
                for (int v = 0; v < i; v++)
                {
                    sum += _nums[v];
                }
                dp[i] = sum;
                return dp[i];
            }
        }
    }
}
