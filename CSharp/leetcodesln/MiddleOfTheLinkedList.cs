using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var count = 1;
            var temp = head;
            while(temp.next!=null)
            {
                count++;
                temp = temp.next;
            }
            for (int i = 0; i < count/2; i++)
            {
                head = head.next;
            }
            return head;
        }
    }
}
