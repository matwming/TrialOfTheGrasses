using System;

namespace leetcodesln
{
    public class MaxAreaOfIsland
    {
        public int MaxAreaOfIslandSln(int[,] grid)
        {
            int maxArea = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j]==1) {
                        maxArea = Math.Max(maxArea, AreaOfIsland(grid,i,j));
                    }
                }
            }
                return maxArea;
        }

        public int AreaOfIsland(int[,] grid, int i, int j) {
            if(i>=0 && i< grid.GetLength(0) && j>=0 && j< grid.GetLength(1) && grid[i,j] == 1) {
                grid[i,j] = 0;
                return 1+ AreaOfIsland(grid,i-1,j) + AreaOfIsland(grid, i+1,j) + AreaOfIsland(grid,i,j-1) + AreaOfIsland(grid,i,j+1);
            }
            return 0;
        }
    }
}
