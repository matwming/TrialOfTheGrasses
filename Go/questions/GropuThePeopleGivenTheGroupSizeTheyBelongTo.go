package questions

func GroupThePeople(groupSizes []int) [][]int {
	ans := make([][]int, 0)

	m := make(map[int][]int)

	for i, v := range groupSizes {
		if val, ok := m[v]; ok {
			val = append(val, i)
		} else {
			m[v] = append(m[v], i)
		}
		if len(m[v]) == v {
			ans = append(ans, m[v])
			m[v] = []int{}
		}
	}
	return ans
}
