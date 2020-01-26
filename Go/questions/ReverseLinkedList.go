package questions

import "github.com/leetcode/common"

func ReverseList(head *common.ListNode) *common.ListNode {
	if head == nil || head.Next == nil {
		return head
	}

	newHead := ReverseList(head.Next)
	head.Next.Next = head
	head.Next = nil
	return newHead
}
