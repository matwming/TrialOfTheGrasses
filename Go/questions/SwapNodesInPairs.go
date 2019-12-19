package questions

import "github.com/leetcode/common"

func SwapPairs(head *common.ListNode) *common.ListNode {
	if head == nil || head.Next == nil {
		return head
	}

	newHead := SwapPairs(head.Next.Next)
	head.Val, head.Next.Val = head.Next.Val, head.Val
	head.Next.Next = newHead
	return head
}
