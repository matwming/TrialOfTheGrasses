using System.Collections.Generic;

namespace leetcodesln
{
    public class PathInZigzagLabelledBinaryTree
    {
        public IList<int> PathInZigZagTree(int label)
        {
            var row = 0;
            var ans = new List<int>() { label };

            while (label >= 1 << row + 1) row++;

            while (row > 0)
            {
                var preivous = (1 << row) + ((1 << row - 1) - 1) - label / 2;
                ans.Insert(0, preivous);
                row--;
                label = preivous;

            }

            return ans;
        }
    }
}
