package questions

func MaxArea(height []int) int {
	ans, l , r := 0, 0, len(height)-1

	for l < r {
		cur := (r -l) * min(height[l],height[r])
		ans = max(ans, cur)
		if height[l] < height[r] {
			l++
		} else {
			r--
		}
	}
	return ans
}

func min(a int, b int) int {
	if a < b {
		return a
	} else {
		return b
	}
}

func max(a int, b int) int {
	if a > b {
		return a
	} else {
		return b
	}
}
