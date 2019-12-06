// dummy node
class Solution {
  public ListNode reverseList(ListNode head) {
    if (head == null || head.next == null) {
      return head;
    }

    ListNode dummy = new ListNode(0);
    while (head != null) {
      ListNode temp = head.next;
      head.next = dummy.next;
      dummy.next = head;
      head = temp;
    }

    return dummy.next;
  }
}