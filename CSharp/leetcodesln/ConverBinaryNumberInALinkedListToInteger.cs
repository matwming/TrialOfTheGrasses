using System;
using System.Text;

namespace leetcodesln
{
    public class ConverBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }

            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}
