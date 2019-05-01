using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ColoringABorder
    {

        public int[][] ColorBorder(int[][] grid, int r0, int c0, int color)
        {
            bool[][] check = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                check[i] = new bool[grid[i].Length];
            }

            var queue = new Queue<int[]>();

            int[][] dirs = new int[4][];
            dirs[0] = new int[] { 1, 0 };
            dirs[1] = new int[] { -1, 0 };
            dirs[2] = new int[] { 0, 1 };
            dirs[3] = new int[] { 0, -1 };

            int val = grid[r0][c0];
            queue.Enqueue(new int[] { r0, c0 });

            while (queue.Count!=0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var point = queue.Dequeue();

                    if(NeedColor(grid,point[0], point[1], val))
                    {
                        check[point[0]][point[1]] = true;
                        grid[point[0]][point[1]] = -grid[point[0]][point[1]];
                    }

                    foreach (var dir in dirs)
                    {
                        int x = point[0] + dir[0];
                        int y = point[1] + dir[1];

                        if (x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length || check[x][y]) continue;
                        if (grid[x][y] == val)
                        {
                            queue.Enqueue(new int[] { x, y });
                            check[x][y] = true;
                        }
                    }


                }

            }

            for (int a = 0; a < grid.Length; a++)
            {
                for (int b = 0; b < grid[a].Length; b++)
                {
                    if (grid[a][b]< 0) grid[a][b] = color;
                }
            }
            return grid;
        }

        private bool NeedColor(int[][] grid, int x, int y, int val)
        {
            int[][] dirs = new int[4][];
            dirs[0] = new int[] { 1, 0 };
            dirs[1] = new int[] { -1, 0 };
            dirs[2] = new int[] { 0, 1 };
            dirs[3] = new int[] { 0, -1 };

            if (x == 0 || y == 0 || x == grid.Length - 1 || y == grid[0].Length - 1) return true;
            foreach (var dir in dirs)
            {
                int xx = x + dir[0];
                int yy = y + dir[1];
                if (xx < 0 || yy < 0 || xx >= grid.Length || yy >= grid[0].Length) continue;
                if (Math.Abs(grid[xx][yy]) != val) return true;
            }
            return false;
        }
    }
}
