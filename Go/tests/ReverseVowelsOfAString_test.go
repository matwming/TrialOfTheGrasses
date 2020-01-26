package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestReverseVowelsOfAString(t *testing.T) {
	input := "hello"
	expected := "holle"
	actual := questions.ReverseVowels(input)
	assert.Equal(t, expected, actual)
}
