﻿namespace leetcodesln
{
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p==null || q==null)
            {
                return p == q;
            }
            if(p.val==q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            return false;
        }
    }
}
