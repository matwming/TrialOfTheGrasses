using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class MinimumAbsoluteDifferenceInBST
    {
        public int GetMinimumDifference(TreeNode root)
        {

            if (root.left == null && root.right == null)
            {
                return 0;
            }

        }

        private int getDifference(TreeNode root)
        {
            int smallest = Int32.MaxValue;
            if (root.left == null && root.right == null)
            {
                return smallest;
            }
            if (true)
            {

            }
        }
    }
}
