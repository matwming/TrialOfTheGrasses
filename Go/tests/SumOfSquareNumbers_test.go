package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestSumOfSquareNumbers1(t *testing.T) {
	input := 0
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, true, actual)
}

func TestSumOfSquareNumbers2(t *testing.T) {
	input := 5
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, true, actual)
}

func TestSumOfSquareNumbers3(t *testing.T) {
	input := 3
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, false, actual)
}

func TestSumOfSquareNumbers4(t *testing.T) {
	input := 4
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, true, actual)
}
