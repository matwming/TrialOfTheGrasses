namespace leetcodesln
{
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var newHead = SwapPairs(head.next.next);
            var temp = head.val;
            head.val = head.next.val;
            head.next.val = temp;
            head.next.next = newHead;
            return head;
        }
    }
}
