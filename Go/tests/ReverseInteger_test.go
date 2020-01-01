package tests

import (
	"gotest.tools/assert"
	re "github.com/leetcode/questions"
	"testing"
)

func TestReverseInteger1(t *testing.T) {
	input := 123
	expected := 321
	actual := re.ReverseInteger(input)
	assert.Equal(t, expected,actual)
}

func TestReverseInteger2(t *testing.T) {
	input := -123
	expected := -321
	actual := re.ReverseInteger(input)
	assert.Equal(t, expected,actual)
}

func TestReverseInteger3(t *testing.T) {
	input := 120
	expected := 21
	actual := re.ReverseInteger(input)
	assert.Equal(t, expected,actual)
}

func TestReverseInteger4(t *testing.T) {
	input := 1534236469
	expected := 0
	actual := re.ReverseInteger(input)
	assert.Equal(t, expected,actual)
}