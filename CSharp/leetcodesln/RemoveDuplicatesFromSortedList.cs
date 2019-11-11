using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            head.next = DeleteDuplicates(head.next);
            return head = head.val == head.next.val ? head.next : head;
        }
    }
}
