namespace leetcodesln
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            var explorer = head;
            var newHead = default(ListNode);

            while (explorer != null)
            {
                if (explorer.next == null)
                {
                    head = head.next;
                    break;
                }
                else
                {
                    explorer = explorer.next.next;
                }

                var next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }

            while (newHead != null)
            {
                if (newHead.val == head.val)
                {
                    newHead = newHead.next;
                    head = head.next;
                }
                else return false;
            }
            return true;
        }
    }
}
