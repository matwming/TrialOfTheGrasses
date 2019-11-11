using System.Collections.Generic;

namespace leetcodesln
{
    public class QueensThatCanAttackTheKing
    {
        public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {
            var ans = new List<IList<int>>();
            var board = new bool[8, 8];
            foreach (var q in queens)
            {
                board[q[0], q[1]] = true;
            }
            foreach (var ix in new[] { 1, 0, -1 })
            {

                foreach (var iy in new[] { 1, 0, -1 })
                {
                    int x = king[0];
                    int y = king[1];
                    if (ix == 0 && iy == 0) continue;
                    while (x + ix >= 0 && x + ix < 8 && y + iy >= 0 && y + iy < 8)
                    {
                        x += ix;
                        y += iy;
                        if (board[x, y])
                        {
                            ans.Add(new[] { x, y });
                            break;
                        }
                    }
                }
            }
            return ans;
        }
    }
}
