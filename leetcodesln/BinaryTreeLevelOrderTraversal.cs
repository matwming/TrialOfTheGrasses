using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();

            var ans = new List<IList<int>>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                var list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    list.Add(current.val);
                    if (current.left != null) q.Enqueue(current.left);
                    if (current.right != null) q.Enqueue(current.right);
                }
                ans.Add(list);
            }
            return ans;
        }
    }
}
