using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var ans = new List<int>();

            if (root == null) return ans;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                ans.Add(q.Peek().val);
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    if (current.right != null) q.Enqueue(current.right);
                    if (current.left != null) q.Enqueue(current.left);
                }
            }
            return ans;
        }
    }
}
