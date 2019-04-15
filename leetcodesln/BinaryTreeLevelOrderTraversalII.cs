using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class BinaryTreeLevelOrderTraversalII
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var ans = new List<IList<int>>();
            if (root == null) return ans;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                IList<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    list.Add(current.val);
                    if (current.left != null) q.Enqueue(current.left);
                    if (current.right != null) q.Enqueue(current.right);
                }
                ans.Insert(0, list);
            }
            return ans;
        }
    }
}
