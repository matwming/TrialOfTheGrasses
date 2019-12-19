package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestReverseVowelsOfAString(t *testing.T) {
	input := "hello"
	expected := "holle"
	actual := questions.ReverseVowels(input)
	assert.Equal(t, expected,actual)
}
