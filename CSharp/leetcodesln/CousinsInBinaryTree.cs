using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class CousinsInBinaryTree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null || root.val == x || root.val == y) return false;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                bool foundx = false, foundy = false;
                int size = q.Count;
                TreeNode fatherx = null;
                TreeNode fathery = null;
                for (int i = 0; i < size; i++)
                {
                    var current = q.Dequeue();
                    if (current.left != null)
                    {
                        foundx = foundx || current.left.val == x;
                        q.Enqueue(current.left);
                        foundy = foundy || current.left.val == y;
                        fatherx = foundx && foundx ? fatherx ?? current : null;
                        fathery = foundy ? fathery ?? current : null;
                    }
                    if (current.right != null)
                    {
                        foundx = foundx || current.right.val == x;
                        q.Enqueue(current.right);
                        foundy = foundy || current.right.val == y;
                        fatherx = foundx && foundx ? fatherx ?? current : null;
                        fathery = foundy ? fathery ?? current : null;
                    }
                }
                if (foundx && foundy && fatherx != fathery && fatherx != null && fathery != null) return true;
            }
            return false;
        }
    }
}
