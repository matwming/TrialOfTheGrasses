using System.Collections.Generic;

namespace leetcodesln
{
    public class TreasureIsland
    {
        public int ShortestPath(char[][] map)
        {
            int? shortestPath = null;

            var directions = new int[4][];
            directions[0] = new[] { 1, 0 };
            directions[1] = new[] { 0, 1 };
            directions[2] = new[] { -1, 0 };
            directions[3] = new[] { 0, -1 };

            if (map[0][0] == 'D') return -1;

            var q = new Queue<int[]>();
            q.Enqueue(new[] { 0, 0, 1 });

            while (q.Count != 0)
            {
                var current = q.Dequeue();
                foreach (var dir in directions)
                {
                    var x = current[0] + dir[0];
                    var y = current[1] + dir[1];
                    if (x < 0 || x >= map.Length || y < 0 || y >= map[0].Length) continue;
                    if (map[x][y] == 'O')
                    {
                        map[x][y] = 'D';
                        q.Enqueue(new[] { x, y, current[2] + 1 });
                    }
                    if (map[x][y] == 'X')
                    {
                        if (shortestPath.HasValue)
                        {
                            shortestPath = shortestPath > current[2] ? current[2] : shortestPath;
                        }
                        else
                        {
                            shortestPath = current[2];
                        }
                    }
                }
            }
            return shortestPath.HasValue ? shortestPath.Value : -1;
        }
    }
}