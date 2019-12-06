/**
 * Definition for singly-linked list. public class ListNode { int val; ListNode
 * next; ListNode(int x) { val = x; } }
 */
class Solution {
  public ListNode swapPairs(ListNode head) {
    if (head == null || head.next == null) {
      return head;
    }

    ListNode dummy = new ListNode(0);
    ListNode current = dummy;
    int counter = 0;
    while (head != null) {
      if (counter == 2) {
        current = current.next.next;
        counter = 0;
      }

      ListNode temp = head.next;
      head.next = current.next;
      current.next = head;
      head = temp;
      counter++;
    }

    return dummy.next;
  }
}