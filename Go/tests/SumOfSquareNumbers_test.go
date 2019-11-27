package tests

import (
	"gotest.tools/assert"
	"m/v2/questions"
	"testing"
)

func TestSumOfSquareNumbers1(t *testing.T) {
	input := 0
	expected := true
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, expected, actual)
}

func TestSumOfSquareNumbers2(t *testing.T) {
	input := 5
	expected := true
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, expected, actual)
}

func TestSumOfSquareNumbers3(t *testing.T) {
	input := 3
	expected := false
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, expected, actual)
}

func TestSumOfSquareNumbers4(t *testing.T) {
	input := 4
	expected := true
	actual := questions.JudgeSquareSum(input)
	assert.Equal(t, expected, actual)
}