using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class LowestCommonAncestorOfDeepestLeaves
    {
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            TreeNode ans = null;
            var q = new Queue<NodeWDepth>();
            var maxDepth = 0;

            if (root == null) { return null; }

            q.Enqueue(new NodeWDepth(root, 1, null));

            while (q.Count != 0)
            {
                var current = q.Dequeue();
                if (current.node.left == null && current.node.right == null)
                {
                    if (current.depth > maxDepth)
                    {
                        ans = current.father ?? current.node;
                    }
                }
                else
                {
                    if (current.node.left != null)
                    {
                        q.Enqueue(new NodeWDepth(current.node.left, current.depth + 1, current.node));
                    }
                    if (current.node.right != null)
                    {
                        q.Enqueue(new NodeWDepth(current.node.right, current.depth + 1, current.node));
                    }
                }
                maxDepth++;

            }

            return ans;
        }
    }

    struct NodeWDepth
    {
        public TreeNode node;
        public int depth;
        public TreeNode father;
        public NodeWDepth(TreeNode node, int depth, TreeNode father)
        {
            this.node = node;
            this.depth = depth;
            this.father = father;
        }
    }
}
