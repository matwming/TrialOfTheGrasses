using leetcodesln.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ConvertBSTToGreaterTree
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root==null)
            {
                return root;
            }
            root.right.val = SumRightNode(root.right);
            root.left.val += root.val + SumRightNode(root.left.right);
            return root;
            
        }

        private int SumRightNode(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.right==null)
            {
                return node.val;
            }
            else
            {
                node.val += SumRightNode(node.right);
                return node.val;
            }
        }
       
    }
}
