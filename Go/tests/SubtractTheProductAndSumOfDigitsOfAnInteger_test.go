package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestSubtractProductSum(t *testing.T) {
	n := 234
	expected := 15
	actual := questions.SubtractProductAndSum(n)
	assert.Equal(t, expected, actual)
}
