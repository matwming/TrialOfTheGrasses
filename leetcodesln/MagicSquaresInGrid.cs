namespace leetcodesln
{
    public class MagicSquaresInGrid
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            var count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (IsValidGrid(i, j, grid))
                    {
                        if (grid[i][j] == grid[i + 1][j] || grid[i + 1][j] == grid[i + 2][j] || grid[i][j] == grid[i + 2][j]) continue;
                        var sumOfRow = grid[i][j] + grid[i + 1][j] + grid[i + 2][j];
                        if (CheckRest(sumOfRow, i, j, grid)) count++;
                    }
                }
            }
            return count;
        }

        private bool CheckRest(int sumOfRow, int i, int j, int[][] grid)
        {
            if (grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] != sumOfRow || grid[i + 1][j] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i + 1][j + 2] || grid[i + 1][j] == grid[i + 1][j + 2]) return false;
            if (grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] != sumOfRow || grid[i + 2][j] == grid[i + 2][j + 1] || grid[i + 2][j + 1] == grid[i + 2][j + 2] || grid[i + 2][j] == grid[i + 2][j + 2]) return false;
            if (grid[i][j] + grid[i + 1][j] + grid[i + 2][j] != sumOfRow || grid[i][j] == grid[i + 1][j] || grid[i + 1][j] == grid[i + 2][j] || grid[i][j] == grid[i + 2][j]) return false;
            if (grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] != sumOfRow || grid[i][j + 1] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i + 2][j + 1] || grid[i][j + 1] == grid[i + 2][j + 1]) return false;
            if (grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] != sumOfRow || grid[i + 2][j] == grid[i + 2][j + 1] || grid[i + 2][j + 1] == grid[i + 2][j + 2] || grid[i + 2][j] == grid[i + 2][j + 2]) return false;
            if (grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] != sumOfRow || grid[i][j] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i + 2][j + 2] || grid[i][j] == grid[i + 2][j + 2]) return false;
            if (grid[i + 2][j] + grid[i + 1][j + 1] + grid[i][j + 2] != sumOfRow || grid[i + 2][j] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i][j + 2] || grid[i + 2][j] == grid[i][j + 2]) return false;
            return true;

        }

        private bool IsValidGrid(int i, int j, int[][] grid)
        {
            return i + 2 <= grid.Length - 1 && j + 2 <= grid[0].Length - 1;
        }
    }
}
