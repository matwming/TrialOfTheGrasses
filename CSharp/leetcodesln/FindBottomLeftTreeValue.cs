using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            var ans = root.val;
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    if (current.right != null) ans = current.right.val;
                    if (current.left != null) ans = current.left.val;
                    if (current.right != null) q.Enqueue(current.right);
                    if (current.left != null) q.Enqueue(current.left);
                }
            }
            return ans;
        }
    }
}
