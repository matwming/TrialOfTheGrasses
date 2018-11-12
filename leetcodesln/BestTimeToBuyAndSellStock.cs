using System;
using System.Linq;

namespace leetcodesln
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if(prices.Length < 2) return 0;
            int maxProfit = 0;
            int currentMax = prices[prices.Length-1];
            for (int i = prices.Length -2 ; i >= 0; i--)
            {
                if(currentMax - prices[i]>0 && currentMax - prices[i] > maxProfit) maxProfit = currentMax - prices[i];
                if(prices[i] > currentMax) currentMax = prices[i];
            }
            return maxProfit;
        }
    }
}