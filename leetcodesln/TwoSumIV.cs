using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class TwoSumIV
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null) 
            {
                return false;
            }

            if (Math.Abs(root.val -k) >= root.val)
            {
                return FindRecursively(root.right, Math.Abs(root.val - k));
            }
            return FindRecursively(root.left, Math.Abs(root.val - k));
        }

        private bool FindRecursively(TreeNode node, int target)
        {
            if (node == null)
            {
                return false;
            }
            if (node.val == target)
            {
                return true;
            }
            if (node.val > target)
            {
                return FindRecursively(node.left, target);
            }
            if (node.val < target)
            {
                return FindRecursively(node.right, target);
            }
            return false;
        }
    }
}
