using System;
using System.Linq;

namespace leetcodesln
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var max = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                var remains = new int[prices.Length -i-1];
                Array.Copy(prices,i+1, remains, 0, prices.Length-i-1);
                var temp = FindMax(remains)- prices[i];
                if(temp>0 && temp > max) max = temp;
            }
            return max;
        }

        private int FindMax(int[] prices)
        {
            return prices.Max();
        }
    }
}