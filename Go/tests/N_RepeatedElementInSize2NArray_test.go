package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestN_RepeatedElementInSize2NArray(t *testing.T) {
	input := []int{1,2,3,3}
	expected := 3
	actual := questions.RepeatedNTimes(input)
	assert.Equal(t, expected, actual)
}
