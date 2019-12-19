package questions

import "github.com/leetcode/common"

func DeleteDuplicates(head *common.ListNode) *common.ListNode {
	if head == nil || head.Next == nil {
		return head
	}

	head.Next = DeleteDuplicates(head.Next)
	if head.Val == head.Next.Val {
		head = head.Next
	}
	return head
}
