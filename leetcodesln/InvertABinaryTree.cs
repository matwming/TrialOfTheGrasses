using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class InvertABinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            var temp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);
            return root;
        }
    }
}
