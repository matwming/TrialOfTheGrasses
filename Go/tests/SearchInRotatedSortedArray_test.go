package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestSearchInRotatedSortedArray(t *testing.T) {
	nums := []int{4, 5, 6, 7, 0, 1, 2}
	target := 0
	expected := 4
	actual := questions.SearchInRotatedSortedArray(nums, target)
	assert.Equal(t, expected, actual)
}
