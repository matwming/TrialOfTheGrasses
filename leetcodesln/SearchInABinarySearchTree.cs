using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root==null)
            {
                return null;
            }
            if (root.val==val)
            {
                return root;
            }
            if (root.val> val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }
    }
}
