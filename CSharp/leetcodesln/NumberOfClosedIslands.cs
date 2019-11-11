using System.Collections.Generic;

namespace leetcodesln
{
    public class NumberOfClosedIslands
    {
        public int ClosedIsland(int[][] grid)
        {
            int ans = 0;
            int row = grid.Length;
            int col = grid[0].Length;

            bool[,] visited = new bool[row, col];

            for (int i = 1; i < grid.Length - 1; ++i)
            {
                for (int j = 1; j < grid[i].Length - 1; ++j)
                {
                    if (grid[i][j] == 0 && !visited[i, j])
                    {
                        bool isClosed = BFS(grid, i, j, visited);
                        if (isClosed) ans++;
                    }
                }
            }
            return ans;
        }

        private bool BFS(int[][] grid, int x, int y, bool[,] visited)
        {
            int[][] directions = new int[4][];
            directions[0] = new[] { 0, 1 };
            directions[1] = new[] { 1, 0 };
            directions[2] = new[] { -1, 0 };
            directions[3] = new[] { 0, -1 };
            var q = new Queue<int[]>();
            q.Enqueue(new int[] { x, y });

            while (q.Count != 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; ++i)
                {
                    var current = q.Dequeue();
                    foreach (var dir in directions)
                    {
                        var xx = current[0] + dir[0];
                        var yy = current[1] + dir[1];

                        if (xx >= 0 && xx < grid.Length && yy >= 0 && yy < grid[0].Length)
                        {
                            if (grid[xx][yy] == 0 && (xx == 0 || yy == 0)) return false;
                            else if (grid[xx][yy] == 0 && !visited[xx, yy])
                            {
                                visited[xx, yy] = true;
                                q.Enqueue(new int[] { xx, yy });
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
