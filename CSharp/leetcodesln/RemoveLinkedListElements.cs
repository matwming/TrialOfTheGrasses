namespace leetcodesln
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class RemoveLinkedListElements
    {

#pragma warning disable IDE0051 // Remove unused private members
        private ListNode RemoveElements(ListNode head, int val)
#pragma warning restore IDE0051 // Remove unused private members
        {
            var virtualStartNode = new ListNode(0)
            {
                next = head
            };

            var nxt = virtualStartNode.next;
            var cur = virtualStartNode;
            while (nxt != null)
            {
                if (nxt.val == val)
                {
                    cur.next = nxt.next ?? null;
                    nxt = nxt.next;
                }
                else
                {
                    cur = cur.next;
                    nxt = nxt.next;
                }
            }
            return virtualStartNode.next;
        }
    }
}
