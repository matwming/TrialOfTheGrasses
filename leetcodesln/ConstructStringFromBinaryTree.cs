using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ConstructStringFromBinaryTree
    {
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
            if (t.left!=null || t.right!=null)
            {
                sb.Append("(");
                PreOrder(t.left, sb);
                sb.Append(")");
            }
            if (t.right!=null)
            {
                sb.Append("(");
                PreOrder(t.right, sb);
                sb.Append(")");
            }
            return sb;
        }
    }
}
