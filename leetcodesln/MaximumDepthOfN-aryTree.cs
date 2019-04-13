using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class MaximumDepthOfN_aryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null) return 0;
            var depth = 0;
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                ++depth;
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    for (int j = 0; j < current.children.Count; j++)
                    {
                        queue.Enqueue(current.children[j]);
                    }
                }
            }
            return depth;

        }
    }
}
