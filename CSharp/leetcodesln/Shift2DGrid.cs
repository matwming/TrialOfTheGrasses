using System.Collections.Generic;

namespace leetcodesln
{
    public class Shift2DGrid
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;

            var ans = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(new List<int>());
                for (int j = 0; j < m; j++)
                {
                    ans[i].Add(0);
                }
            }


            for (int i = 0; i < m * n; i++)
            {
                int j = (i + k) % (m * n);
                ans[j / m][j % m] = grid[i / m][i % m];
            }
            return ans;
        }
    }
}
