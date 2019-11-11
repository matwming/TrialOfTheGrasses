using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class MaximumLevelSumOfABinaryTree
    {
        public int MaxLevelSum(TreeNode root)
        {
            int ans = 0;
            int minLevel = 1;
            if (root == null) { return ans; }

            var q = new Queue<MLS>();
            q.Enqueue(new MLS(root, 1));
            int maxSum = root.val;

            while (q.Count != 0)
            {

                var curLevel = q.Peek().Level + 1;
                var curSum = 0;
                int count = q.Count;

                for (int i = 0; i < count; i++)
                {
                    var current = q.Dequeue();
                    if (current.node.left != null)
                    {
                        curSum += current.node.left.val;
                        q.Enqueue(new MLS(current.node.left, curLevel));
                    }
                    if (current.node.right != null)
                    {
                        curSum += current.node.right.val;
                        q.Enqueue(new MLS(current.node.right, curLevel));
                    }

                }
                if (maxSum <= curSum)
                {
                    if (maxSum == curSum) continue;
                    maxSum = curSum;
                    minLevel = curLevel;
                }

            }
            return minLevel;
        }
    }

    struct MLS
    {
        public TreeNode node;
        public int Level;
        public MLS(TreeNode node, int level)
        {
            this.node = node;
            this.Level = level;
        }
    }
}
