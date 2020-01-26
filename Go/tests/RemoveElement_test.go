package tests

import (
	re "github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestRemoveElement(t *testing.T) {
	nums := []int{3, 2, 2, 3}
	val := 3
	expected := 2
	actual := re.RemoveElement(nums, val)
	assert.Equal(t, expected, actual)

}
