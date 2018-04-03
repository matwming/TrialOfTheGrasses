using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class TwoSumIV
    {
        public bool FindTarget(TreeNode root, int k)
        {
            return DepthFirstSearch(root, root, k);
        }

        private bool DepthFirstSearch(TreeNode root, TreeNode current, int diff)
        {
            if (current == null)
            {
                return false;
            }
            return Search(root, current, diff - current.val) || DepthFirstSearch(root, current.left, diff) || DepthFirstSearch(root, current.right, diff);
        }

        private bool Search(TreeNode root, TreeNode current, int diff)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.val == diff && root != current)
            {
                return true;
            }
            else if (diff > root.val)
            {
                return Search(root.right, current, diff);
            }
            else if (diff < root.val)
            {
                return Search(root.left, current, diff);
            }
            else return false;
        }
    }
}
