namespace leetcodesln
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            var node_fast = head;
            var node_slow = head;

            while (node_fast.next != null && node_slow.next != null)
            {
                if (node_fast.next.next == null) return false;
                node_fast = node_fast.next.next;
                node_slow = node_slow.next;
                if (node_fast == node_slow) return true;
            }
            return false;
        }
    }
}
