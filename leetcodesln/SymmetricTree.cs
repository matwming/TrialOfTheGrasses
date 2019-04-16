using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                var list = new List<int?>();
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    if (current.left != null)
                    {
                        list.Add(current.left.val);
                        q.Enqueue(current.left);
                    }
                    else
                    {
                        list.Add(null);
                    }
                    if (current.right != null)
                    {
                        list.Add(current.right.val);
                        q.Enqueue(current.right);
                    }
                    else
                    {
                        list.Add(null);
                    }
                }
                int left = 0, right = list.Count - 1;
                while (left < right)
                {
                    if (list[left++] != list[right--]) return false;
                }
            }
            return true;
        }
    }
}
