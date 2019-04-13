using System.Collections.Generic;

namespace leetcodesln
{
    public class RottingOranges
    {

        // bfs
        public int OrangesRotting(int[][] grid)
        {
            var numberOfFreshOranges = 0;
            var queue = new Queue<int[]>();
            var mins = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1) ++numberOfFreshOranges;
                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue(new int[] { i, j });
                    }
                }
            }

            if (numberOfFreshOranges == 0) return 0;

            int[][] adjacents = new int[4][];
            adjacents[0] = new int[] { 1, 0 };
            adjacents[1] = new int[] { -1, 0 };
            adjacents[2] = new int[] { 0, 1 };
            adjacents[3] = new int[] { 0, -1 };

            while (queue.Count > 0)
            {
                ++mins;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] point = queue.Dequeue();
                    foreach (var dir in adjacents)
                    {
                        int x = point[0] + dir[0];
                        int y = point[1] + dir[1];

                        if (x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length || grid[x][y]==0 || grid[x][y]==2) continue;
                        grid[x][y] = 2;
                        queue.Enqueue(new int[] { x, y });
                        --numberOfFreshOranges;
                    }
                }
            }

            return numberOfFreshOranges == 0 ? mins - 1 : -1;


        }
    }
}
