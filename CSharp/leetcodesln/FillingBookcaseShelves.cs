using System;

namespace leetcodesln
{
    public class FillingBookcaseShelves
    {
        public int MinHeightShelves(int[][] books, int shelf_width)
        {
            // store current optimised height
            var dp = new int[books.Length + 1];
            dp[0] = 0;

            for (int i = 1; i <= books.Length; ++i)
            {
                int width = books[i - 1][0];
                int height = books[i - 1][1];
                dp[i] = dp[i - 1] + height;

                for (int j = i - 1; j > 0 && width + books[j - 1][0] <= shelf_width; --j)
                {
                    var newHeight = Math.Max(books[j - 1][1], height);
                    width += books[j - 1][0];
                    dp[i] = Math.Min(dp[i], dp[j - 1] + newHeight);
                }
            }
            return dp[books.Length];
        }
    }
}
