package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func Test3Sum(t *testing.T) {
	nums := []int{-1, 0, 1, 2, -1, -4}
	expected := [][]int{
		{-1, 2, -1},
		{0, 1, -1},
	}
	actual := questions.ThreeSum(nums)

	for i1, val := range expected {
		for i2, v := range val {
			assert.Equal(t, actual[i1][i2], v)
		}
	}
}
