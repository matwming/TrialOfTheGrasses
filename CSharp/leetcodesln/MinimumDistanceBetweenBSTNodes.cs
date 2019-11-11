using leetcodesln.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MinimumDistanceBetweenBSTNodes
    {
        private int? min = default;

        private TreeNode pre = null;

        public int MinDiffInBST(TreeNode root)
        {
            if (root.left != null) MinDiffInBST(root.left);
            if (pre != null)
            {
                min = min == null ? root.val - pre.val : Math.Min(min.Value, root.val - pre.val);
                
            }
            pre = root;
            if (root.right != null) MinDiffInBST(root.right);
            return min.GetValueOrDefault();
        }
    }
}
