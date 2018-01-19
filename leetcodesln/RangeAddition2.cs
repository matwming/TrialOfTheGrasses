using System;

namespace leetcodesln
{
    public class RangeAddition2
    {
        public int MaxCount(int m, int n, int[,] ops)
        {
            int maxRowCovered = m;
            int maxColCovered = n;

            for (int i = 0; i < ops.GetLength(0); i++)
            {
                maxRowCovered = Math.Min(maxRowCovered, ops[i, 0]);
                maxColCovered = Math.Min(maxColCovered,ops[i,1]);
            }
            return maxColCovered * maxRowCovered;
        }
    }
}
