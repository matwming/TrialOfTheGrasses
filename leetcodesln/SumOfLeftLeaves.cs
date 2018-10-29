using leetcodesln.common;

namespace leetcodesln
{
   
    public class SumOfLeftLeaves
    {

        public int SumOfLeftLeavesSln(TreeNode root)
        {
            int result = 0;
            if (root==null)
            {
                return 0;
            }
            if (root.left !=null)
            {
                if (root.left.left==null && root.left.right==null)
                {
                    result += root.left.val;
                }
                else
                {
                   result += SumOfLeftLeavesSln(root.left);
                }
            }
            if (root.right!=null)
            {
                result+= SumOfLeftLeavesSln(root.right);
            }
            return result;
        }
    }
}
