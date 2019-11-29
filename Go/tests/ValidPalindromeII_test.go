package tests

import (
	"gotest.tools/assert"
	"m/v2/questions"
	"testing"
)

func TestValidPalindromeII1(t *testing.T) {
	input := "abca"
	expected := true
	actual := questions.ValidPalindromeII(input)
	assert.Equal(t, expected,actual)
}

func TestValidPalindromeII2(t *testing.T) {
	input := "abc"
	expected := false
	actual := questions.ValidPalindromeII(input)
	assert.Equal(t, expected,actual)
}

func TestValidPalindromeII3(t *testing.T) {
	input := "atbbga"
	expected := false
	actual := questions.ValidPalindromeII(input)
	assert.Equal(t, expected,actual)
}