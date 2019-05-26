using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class HeightChecker
    {
        public int HeightCheckerSln(int[] heights)
        {
            int ans = 0;
            var copy = new int[heights.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = heights[i];
            }
            Array.Sort(copy);
            for (int i = 0; i < heights.Length; i++) ans += copy[i] - heights[i] == 0 ? 0 : 1;
            return ans;
        }
    }
}
