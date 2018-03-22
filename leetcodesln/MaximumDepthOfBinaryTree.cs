using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            List<int> listOfDepths = new List<int>();
            InOrderTraversal(root, ref listOfDepths, 1);

            listOfDepths.Sort();
            listOfDepths.Reverse();
            return listOfDepths[0];
        } 
        
        private void InOrderTraversal(TreeNode node, ref List<int> list, int currentDepth)
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.left, ref list, currentDepth + 1);
            list.Add(currentDepth);
            InOrderTraversal(node.right, ref list, currentDepth + 1);
        }
    }
}
