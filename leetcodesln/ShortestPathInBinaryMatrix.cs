using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ShortestPathInBinaryMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int? shortestPath = default;

            var directions = new int[8][];
            directions[0] = new int[] { -1, 1 };
            directions[1] = new int[] { 0, 1 };
            directions[2] = new int[] { 1, 1 };
            directions[3] = new int[] { -1, 0 };
            directions[4] = new int[] { 1, 0 };
            directions[5] = new int[] { -1, -1 };
            directions[6] = new int[] { 0, -1 };
            directions[7] = new int[] { 1, -1 };

            var visited = new List<string>();
            visited.Add(new string("0,0"));

            var q = new Queue<int[]>();
            q.Enqueue(new int[] { 0,0});
            var currentDistant = 1;

            while (q.Count != 0)
            {
                
                var point = q.Dequeue();
                foreach (var dir in directions)
                {
                    var x = point[0] + dir[0];
                    var y = point[1] + dir[1];
                    if (x >= 0 && x <= grid.Length - 1 && y >= 0 && y <= grid[0].Length - 1)
                    {
                        if (grid[x][y] == 1) continue;
                        if (x == grid.Length - 1 && y == grid[0].Length - 1)
                        {
                            if (currentDistant + 1 < (shortestPath == null ? int.MaxValue : shortestPath)) shortestPath = currentDistant + 1;
                        }
                        var builder = new StringBuilder();
                        builder.Append(x).Append(",").Append(y);
                        if (visited.Contains(builder.ToString())) continue;
                        visited.Add(builder.ToString());
                        q.Enqueue(new int[] { x, y });
                        currentDistant += 1;
                    }

                }
            }


            return shortestPath == null ? -1 : shortestPath.Value;
        }
    }
}
