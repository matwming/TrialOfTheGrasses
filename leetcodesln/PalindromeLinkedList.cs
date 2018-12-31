namespace leetcodesln
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            var explorer = head.next.next;

            if (explorer == null) return head.val == head.next.val;

            var left = head;
            ListNode right = null;



            while (explorer.next != null)
            {
                if (explorer.next.next != null)
                {
                    left = left.next;
                    right = left.next.next;
                    explorer = explorer.next.next;
                }
                else
                {
                    left = left.next;
                    right = left.next;
                    explorer = explorer.next;
                }


            }



            while (right != null)
            {
                if (right.val == left.val)
                {
                    right = right.next;
                    left = left.next;
                }
                else return false;
            }
            return true;
        }
    }
}
