package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestSubtractProductSum(t *testing.T) {
	n := 234
	expected:= 15
	actual := questions.SubtractProductAndSum(n)
	assert.Equal(t, expected, actual)
}
