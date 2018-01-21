using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
    public class SumOfLeftLeaves
    {
        public int SumOfLeftLeavesSln(TreeNode root)
        {
            return ProcessNode(root);
           
        }

        private int ProcessNode(TreeNode node)
        {
            int res = 0;
            if (node==null)
            {
                return res;
            }
            else if (node.left==null && node.right==null)
            {
                res += node.val;
            }
            else
            {
                ProcessNode(node.left);
                ProcessNode(node.right);
            }
            return res;
        }
    }
}
