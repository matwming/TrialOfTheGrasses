using leetcodesln.common;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class MaximumDepthOfN_aryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null) return 0;
            if (root.children == null || root.children.Count == 0) return 1;

            var max = new List<int>();

            foreach (var child in root.children)
            {
                var depth = MaxDepth(child);
                max.Add(depth);
            }
            return max.Max() + 1;
        }
    }
}
