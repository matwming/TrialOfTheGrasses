using System;
using System.Collections.Generic;
using System.Linq;
using leetcodesln.common;

namespace leetcodesln
{
    /// <summary>
    ///  FIXME: no test cases
    /// </summary>
    public class DeleteNodesAndReturnForest
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var ans = new List<TreeNode>();

            Helper(root, true, to_delete, ref ans);
            return ans;
        }

        private TreeNode Helper(TreeNode node, bool isRoot, int[] to_delete, ref List<TreeNode> ans)
        {
            if (node == null) return null;
            bool needDelete = to_delete.Contains(node.val);

            if (isRoot && !needDelete)
            {
                ans.Add(node);
            }
            node.left = Helper(node.left, needDelete, to_delete, ref ans);
            node.right = Helper(node.right, needDelete, to_delete, ref ans);
            return needDelete ? null : node;
        }
    }
}