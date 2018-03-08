using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;

            TreeNode newNode = new TreeNode((t1 == null ? 0 : t1.val) + (t2 == null ? 0 : t2.val))
            {
                left = MergeTrees(t1?.left, t2?.left),
                right = MergeTrees(t1?.right, t2?.right)
            };

            return newNode;
        }
    }
}
