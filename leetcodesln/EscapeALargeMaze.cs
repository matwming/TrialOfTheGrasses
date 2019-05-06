using System.Collections.Generic;

namespace leetcodesln
{
    public class EscapeALargeMaze
    {

        /// <summary>
        ///  This is a correct solution but TLE, it has been proved using c++
        /// </summary>
        /// <param name="blocked"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool IsEscapePossible(int[][] blocked, int[] source, int[] target)
        {
            if (blocked.Length == 0) return true;
            var blockers = new HashSet<string>();
            foreach (var b in blocked)
            {
                blockers.Add(b[0] + "," + b[1]);
            }
            var seen = new HashSet<string>();
            return IsEscapePossibleBFS(blockers, source, target, ref seen) && IsEscapePossibleBFS(blockers, target, source, ref seen);
        }

        private bool IsEscapePossibleBFS(HashSet<string> blockers, int[] source, int[] target, ref HashSet<string> seen)
        {
            if (target[0] < 0 || target[1] < 0 || target[0] >= 1e6 || target[1] >= 1e6) return false;

            var dirs = new int[4][];
            dirs[0] = new int[] { 1, 0 };
            dirs[1] = new int[] { 0, 1 };
            dirs[2] = new int[] { -1, 0 };
            dirs[3] = new int[] { 0, -1 };


            var q = new Queue<int[]>();


            q.Enqueue(source);

            while (q.Count != 0)
            {
                int size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    var point = q.Dequeue();
                    if (point[0] == target[0] && point[1] == target[1]) return true;

                    foreach (var dir in dirs)
                    {
                        int x = point[0] + dir[0];
                        int y = point[1] + dir[1];
                        var str = x + "," + y;
                        if (x >= 0 && x < 1e6 && y >= 0 && y < 1e6 && !blockers.Contains(str) && !seen.Contains(str))
                        {
                            if (target[0] == x && target[1] == y) return true;
                            q.Enqueue(new int[] { x, y });
                            seen.Add(str);
                            if (seen.Count == 2e4) return true;
                        }

                    }
                }
            }
            return false;
        }
    }
}
