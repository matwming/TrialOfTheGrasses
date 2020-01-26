package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestBackspaceStringCompare1(t *testing.T) {
	S, T := "ab#c", "ad#c"
	actual := questions.BackspaceCompare(S, T)
	assert.Equal(t, true, actual)
}

func TestBackspaceStringCompare2(t *testing.T) {
	S, T := "ab##", "c#d#"
	actual := questions.BackspaceCompare(S, T)
	assert.Equal(t, true, actual)
}
