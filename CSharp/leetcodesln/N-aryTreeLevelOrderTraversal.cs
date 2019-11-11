using leetcodesln.common;
using System.Collections.Generic;

namespace leetcodesln
{
    public class N_aryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            if (root == null) return new List<IList<int>>();
            var ans = new List<IList<int>>();
            var q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int size = q.Count;
                IList<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var node = q.Dequeue();
                    list.Add(node.val);
                    if (node.children == null) continue;
                    foreach (var child in node.children)
                    {
                        q.Enqueue(child);
                    }
                }
                ans.Add(list);

            }
            return ans;
        }
    }
}
