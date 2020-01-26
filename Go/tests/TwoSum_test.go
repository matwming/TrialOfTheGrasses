package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestTwoSum(t *testing.T) {
	nums := []int{2, 7, 11, 15}
	target := 9
	expected := []int{1, 0}
	actual := questions.TwoSum(nums, target)
	for i := 0; i < len(expected); i++ {
		assert.Equal(t, expected[i], actual[i])
	}
}
