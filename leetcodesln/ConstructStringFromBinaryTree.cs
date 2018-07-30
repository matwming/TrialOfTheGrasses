using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ConstructStringFromBinaryTree
    {

        //todo: runtime error input : 1,2,3,null,4
        public string Tree2Str(TreeNode t)
        {
            return PreOrder(t, new StringBuilder()).ToString();
        }

        private StringBuilder PreOrder(TreeNode t, StringBuilder sb)
        {
            if (t!=null)
            {
                sb.Append(t.val);
            }
            if (t.left!=null)
            {
                sb.Append("(");
                PreOrder(t.left, sb);
                sb.Append(")");
            }
            if (t.right!=null)
            {
                if (t.left == null)
                {
                    sb.Append("()");
                }
                sb.Append("(");
                PreOrder(t.right, sb);
                sb.Append(")");
            }
            return sb;
        }
    }
}
