package questions

import "sort"

func FindPairs(nums []int, k int) int {
	ans := 0
	sort.Ints(nums)

	for i := 0; i < len(nums)-1; i++ {
		l, r := i+1, len(nums)-1

		for l <= r {
			mid := (l + r) >> 1
			if nums[mid]-nums[i] == k {
				ans++
				break
			} else if nums[mid]-nums[i] > k {
				r = mid - 1
			} else {
				l = mid + 1
			}
		}
		for i < len(nums)-2 && nums[i+1] == nums[i] {
			i++
		}
	}
	return ans

}
