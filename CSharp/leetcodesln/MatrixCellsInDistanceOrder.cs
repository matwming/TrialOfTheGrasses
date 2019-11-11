using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class MatrixCellsInDistanceOrder
    {
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            var dict = new Dictionary<(int x, int y), int>();
            var ans = new int[R * C][];
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    dict.Add((i, j), Math.Abs(r0 - i) + Math.Abs(c0 - j));
                }
            }
            var myList = dict.ToList();
            myList.Sort((p1, p2) => p1.Value.CompareTo(p2.Value));
            for (int i = 0; i < myList.Count; i++)
            {
                ans[i] = new int[] { myList[i].Key.x, myList[i].Key.y };
            }
            return ans;
        }
    }
}
