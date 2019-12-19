package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestContainerWithMostWater(t *testing.T) {
	input := []int{1,8,6,2,5,4,8,3,7}
	expected := 49
	actual := questions.MaxArea(input)
	assert.Equal(t, expected, actual)
}
