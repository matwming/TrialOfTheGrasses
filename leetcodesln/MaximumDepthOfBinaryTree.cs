using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            List<int> list = new List<int>();
            int currentDpeth = 0;
            if (root == null)
            {
                return 0;
            }
            //GetNodeDepth(root, currentDpeth, ref list);
            //if (root.left != null)
            //{
            //    GetNodeDepth(root.left, currentDpeth, ref list);
            //}
            //if (root.right != null)
            //{
            //    GetNodeDepth(root.right, currentDpeth, ref list);
            //}
        }

        private void GetNodeDepth(TreeNode node, int preDepth, ref List<int> list)
        {
            if (node != null)
            {
                GetNodeDepth(node.left, preDepth, ref list);
            } 
        }
    }
}
