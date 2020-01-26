package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestLengthOfLongestSubstring1(t *testing.T) {
	input := "abcabcbb"
	expected := 3
	actual := questions.LengthOfLongestSubstring(input)
	assert.Equal(t, expected, actual)
}

func TestLengthOfLongestSubstring2(t *testing.T) {
	input := "bbbbbb"
	expected := 1
	actual := questions.LengthOfLongestSubstring(input)
	assert.Equal(t, expected, actual)
}
