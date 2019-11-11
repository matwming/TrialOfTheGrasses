using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ShortestPathInBinaryMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {

            if (grid[0][0] == 1) return -1;
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


            var q = new Queue<ShortestPathNode>();
            q.Enqueue(new ShortestPathNode(new int[] { 0, 0 }, 1));

            while (q.Count != 0)
            {

                var ShortestPathNode = q.Dequeue();
                foreach (var dir in directions)
                {
                    var x = ShortestPathNode.point[0] + dir[0];
                    var y = ShortestPathNode.point[1] + dir[1];
                    if (x >= 0 && x <= grid.Length - 1 && y >= 0 && y <= grid[0].Length - 1)
                    {
                        if (grid[x][y] == 1 || grid[x][y] ==2) continue;
                        if (x == grid.Length - 1 && y == grid[0].Length - 1)
                        {
                            if (ShortestPathNode.distant + 1 < (shortestPath == null ? int.MaxValue : shortestPath)) shortestPath = ShortestPathNode.distant + 1;
                        }
                        grid[x][y] = 2;
                        q.Enqueue(new ShortestPathNode(new int[] { x, y }, ShortestPathNode.distant +1));
                    }

                }
            }


            return shortestPath == null ? -1 : shortestPath.Value;
        }
    }

    struct ShortestPathNode
    {
        public int[] point;
        public int distant;

        public ShortestPathNode(int[] point, int distant)
        {
            this.point = point;
            this.distant = distant;
        }
    }
}
