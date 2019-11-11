namespace leetcodesln
{
    public class MagicSquaresInGrid
    {
        //public int NumMagicSquaresInside(int[][] grid)
        //{
        //    var count = 0;

        //    for (int i = 0; i < grid.Length; i++)
        //    {
        //        for (int j = 0; j < grid[i].Length; j++)
        //        {
        //            if (IsValidGrid(i, j, grid))
        //            {
        //                if (grid[i][j] == grid[i + 1][j] || grid[i + 1][j] == grid[i + 2][j] || grid[i][j] == grid[i + 2][j]) continue;
        //                var sumOfRow = grid[i][j] + grid[i + 1][j] + grid[i + 2][j];
        //                if (CheckRest(sumOfRow, i, j, grid)) count++;
        //            }
        //        }
        //    }
        //    return count;
        //}

        //private bool CheckRest(int sumOfRow, int i, int j, int[][] grid)
        //{
        //    if (grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] != sumOfRow || grid[i + 1][j] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i + 1][j + 2] || grid[i + 1][j] == grid[i + 1][j + 2]) return false;
        //    if (grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] != sumOfRow || grid[i + 2][j] == grid[i + 2][j + 1] || grid[i + 2][j + 1] == grid[i + 2][j + 2] || grid[i + 2][j] == grid[i + 2][j + 2]) return false;
        //    if (grid[i][j] + grid[i + 1][j] + grid[i + 2][j] != sumOfRow || grid[i][j] == grid[i + 1][j] || grid[i + 1][j] == grid[i + 2][j] || grid[i][j] == grid[i + 2][j]) return false;
        //    if (grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] != sumOfRow || grid[i][j + 1] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i + 2][j + 1] || grid[i][j + 1] == grid[i + 2][j + 1]) return false;
        //    if (grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] != sumOfRow || grid[i + 2][j] == grid[i + 2][j + 1] || grid[i + 2][j + 1] == grid[i + 2][j + 2] || grid[i + 2][j] == grid[i + 2][j + 2]) return false;
        //    if (grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] != sumOfRow || grid[i][j] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i + 2][j + 2] || grid[i][j] == grid[i + 2][j + 2]) return false;
        //    if (grid[i + 2][j] + grid[i + 1][j + 1] + grid[i][j + 2] != sumOfRow || grid[i + 2][j] == grid[i + 1][j + 1] || grid[i + 1][j + 1] == grid[i][j + 2] || grid[i + 2][j] == grid[i][j + 2]) return false;
        //    return true;

        //}

        //private bool IsValidGrid(int i, int j, int[][] grid)
        //{
        //    return i + 2 <= grid.Length - 1 && j + 2 <= grid[0].Length - 1;
        //}

        public int NumMagicSquaresInside(int[][] grid)
        {
            var count = 0;

            for (int i = 0; i < grid.Length - 2; i++)
            {
                for (int j = 0; j < grid[i].Length - 2; j++)
                {
                    if (IsMagic(grid[i][j], grid[i][j + 1], grid[i][j + 2], grid[i + 1][j], grid[i + 1][j + 1], grid[i + 1][j + 2], grid[i + 2][j], grid[i + 2][j + 1], grid[i + 2][j + 2])) count++;
                }
            }
            return count;
        }

        private bool IsMagic(params int[] vals)
        {
            int[] count = new int[16];
            foreach (var val in vals)
            {
                count[val]++;
            }

            for (int i = 1; i <= 9; i++)
            {
                if (count[i] != 1) return false;
            }

            return (vals[0] + vals[1] + vals[2] == 15 &&
                vals[3] + vals[4] + vals[5] == 15 &&
                vals[6] + vals[7] + vals[8] == 15 &&
                vals[0] + vals[3] + vals[6] == 15 &&
                vals[1] + vals[4] + vals[7] == 15 &&
                vals[2] + vals[5] + vals[8] == 15 &&
                vals[0] + vals[4] + vals[8] == 15 &&
                vals[2] + vals[4] + vals[6] == 15);
        }
    }
}
