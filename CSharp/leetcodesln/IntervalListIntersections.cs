using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class IntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            var ans = new List<int[]>();
            int a = 0, b = 0;
            while (a < A.Length && b < B.Length)
            {
                var low = Math.Max(A[a][0], B[b][0]);
                var high = Math.Min(A[a][1], B[b][1]);
                if (low <= high) ans.Add(new int[] { low, high });
                if (A[a][1] < B[b][1]) a++;
                else b++;
            }
            var result = new int[ans.Count][];
            for (int i = 0; i < ans.Count; ++i)
            {
                result[i] = ans[i];
            }
            return result;
        }
    }
}
