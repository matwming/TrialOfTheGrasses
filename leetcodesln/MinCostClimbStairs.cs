using System;

namespace leetcodesln
{
    public class MinCostClimbStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length<=1)
            {
                return 0;
            }
           int[] dp = new int[cost.Length+1];
           dp[0] = cost[0];
           dp[1] = cost[1];
           for (int i = 2; i < dp.Length; i++)
           {
               int current = i==cost.Length?0:cost[i];
               dp[i] = Math.Min(dp[i-1]+current,dp[i-2]+current);
           }
            return dp[cost.Length];
        }
    }
}