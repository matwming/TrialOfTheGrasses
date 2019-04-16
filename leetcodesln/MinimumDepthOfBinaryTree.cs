using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var minDepth = 1;
            while (q.Count != 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    if (current.left == null && current.right == null) return minDepth;
                    if (current.left != null) q.Enqueue(current.left);
                    if (current.right != null) q.Enqueue(current.right);
                }
                ++minDepth;
            }
            return minDepth;
        }
    }
}
