using System;
using System.Collections.Generic;
using System.Linq;
using leetcodesln.common;

namespace leetcodesln
{
    public class LeafSimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;

            var list1 = new List<int>();
            var list2 = new List<int>();

            FindRecursively(root1, ref list1);
            FindRecursively(root2, ref list2);

            return list1.SequenceEqual(list2);
        }

        private void FindRecursively(TreeNode node, ref List<int> list)
        {
            if (node == null) return;
            if (node.left == null && node.right == null) list.Add(node.val);
            FindRecursively(node.left, ref list);
            FindRecursively(node.right, ref list);
        }
    }
}