using System;

namespace leetcodesln
{
    public class CoinChange
    {
        public int Change(int amount, int[] coins)
        {
            int max = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                max = Math.Max(max, amount / coins[i]+1);
            }
            int[] dp = new int[amount + 1];
            Array.Fill(dp, max+10);

            dp[0] = 0;
            for (int i = 1; i < amount + 1; i++)
            {
                int min = dp[i];
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i - coins[j] >= 0)
                    {
                        min = Math.Min(dp[i - coins[j]] + 1, min);
                    }
                }
                dp[i] = min;
            }
            return dp[amount] == (max+10) ? -1 : dp[amount];
        }
    }
}
