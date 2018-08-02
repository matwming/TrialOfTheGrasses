using System;
using System.Collections.Generic;
using System.Text;

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

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
