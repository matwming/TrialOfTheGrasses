using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var dp = new int[rowIndex][];
            for (int i = 0; i < rowIndex; i++)
            {
                dp[i] = new int[i + 1];
                Array.Fill(dp[i], -1);
            }

            var result = new int[rowIndex + 1];
            Array.Fill(result, 1);
            for (int i = 1; i < result.Length - 1; i++)
            {
                if (result[i] == 1)
                {
                    result[i] = GetValue(rowIndex - 1, i, ref dp);
                }
            }

            return result;
        }

        private int GetValue(int rowIndex, int i, ref int[][] dp)
        {
            if (rowIndex == i - 1 || i == 0) return 1;
            if (dp[rowIndex][i] != -1) return dp[rowIndex][i];

            dp[rowIndex][i] = GetValue(rowIndex - 1, i - 1, ref dp) + GetValue(rowIndex - 1, i, ref dp);
            return dp[rowIndex][i];
        }
    }
}
