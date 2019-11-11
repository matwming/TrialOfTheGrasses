using leetcodesln.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class InvertABinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) { return null; }

            var newRoot = new TreeNode(root.val);
            newRoot.left = InvertTree(root.right);
            newRoot.right = InvertTree(root.left);
            return newRoot;
        }
    }
}
