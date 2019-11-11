using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class N_aryTreePostorderTraversal
    {
        public IList<int> Postorder(Node root)
        {
            List<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            AddChildrenToList(root, res);
            return res;
        }

        private void AddChildrenToList(Node node, IList<int> list)
        {
            if (node.children != null)
            {
                foreach (var item in node.children)
                {
                    AddChildrenToList(item, list);
                }
            }
            list.Add(node.val);
        }
    }
}
