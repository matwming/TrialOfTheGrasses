namespace leetcodesln
{
    public class TrimABinarySearchTree
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return null;

            //if(root.val>=L && root.val<=R)
            //{
            //    TreeNode newNode = new TreeNode(root.val)
            //    {
            //        left = TrimBST(root.left, L, R),
            //        right = TrimBST(root.right, L, R)
            //    };
            //    return newNode;
            //}
            if (root.val < L)
            {
                if (root.right == null)
                {
                    return null;
                }
                TreeNode newNode = new TreeNode(root.right.val)
                {
                    left = TrimBST(root.left, L, R),
                    right = TrimBST(root.right, L, R)
                };
                return newNode;
            }
            else
            {
                if (root.left == null)
                {
                    return null;
                }
                TreeNode newNode = new TreeNode(root.left.val)
                {
                    left = TrimBST(root.left, L, R),
                    right = TrimBST(root.right, L, R)
                };
                return newNode;
            }
        }
    }
}
