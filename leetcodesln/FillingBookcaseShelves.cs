using System;

namespace leetcodesln
{
    public class FillingBookcaseShelves
    {
        public int MinHeightShelves(int[][] books, int shelf_width)
        {
            var minHeight = 0;
            // store current optimised height
            var dp = new int[books.Length + 1];
            dp[0] = 0;

            for (int i = 1; i <= books.Length; ++i)
            {
                int width = books[i - 1][0];
                int height = books[i - 1][1];

                for (int j = i - 1; j >= 0 && width + books[j][0] <= shelf_width; --j)
                {
                    width += books[j][0];
                    var max_height = Math.Max(height, books[j][1]);
                    dp[i] = Math.Min(dp[i], dp[j] + max_height);

                }

            }
            //wip
            return minHeight;
        }
    }
}
