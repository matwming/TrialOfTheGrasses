package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestBackspaceStringCompare1(t *testing.T) {
	S, T := "ab#c", "ad#c"
	expected := true
	actual := questions.BackspaceCompare(S,T)
	assert.Equal(t, expected ,actual)
}

func TestBackspaceStringCompare2(t *testing.T) {
	S, T := "ab##", "c#d#"
	expected := true
	actual := questions.BackspaceCompare(S,T)
	assert.Equal(t, expected ,actual)
}