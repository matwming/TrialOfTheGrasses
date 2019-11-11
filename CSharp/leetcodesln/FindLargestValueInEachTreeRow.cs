using leetcodesln.common;
using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class FindLargestValueInEachTreeRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null) return new int[] { };

            var ans = new List<int>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                var max = int.MinValue;
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    max = Math.Max(max, current.val);
                    if (current.left != null) q.Enqueue(current.left);
                    if (current.right != null) q.Enqueue(current.right);
                }
                ans.Add(max);
            }
            return ans;
        }
    }
}
