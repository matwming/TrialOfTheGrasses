using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class IncreasingOrderSearchTree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null) return null;

            var s = new Stack<TreeNode>();
            var list = new List<int>();
            var current = root;
            while (current != null || s.Count != 0)
            {
                while (current != null)
                {
                    s.Push(current);

                    current = current.left;
                }
                current = s.Peek();
                s.Pop();
                list.Add(current.val);
                current = current.right;
            }
            var ans = new TreeNode(list[0]);
            var walk = ans;
            for (int i = 1; i < list.Count; i++)
            {
                walk.right = new TreeNode(list[i]);
                walk = walk.right;
            }
            return ans;
        }
    }
}
