package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestBullsAndCows(t *testing.T) {
	secret, guess := "1807", "7810"
	expected := "1A3B"
	actual := questions.GetHint(secret, guess)
	assert.Equal(t, expected,actual)
}
