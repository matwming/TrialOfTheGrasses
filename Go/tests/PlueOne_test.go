package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestPlusOne1(t *testing.T) {
	input := []int{1,2,3}
	expected := []int{1,2,4}
	actual := questions.PlusOne(input)
	for i := 0; i < len(expected); i++ {
		assert.Equal(t, expected[i], actual[i])
	}
}

func TestPlusOne2(t *testing.T) {
	input := []int{4,3,2,1}
	expected := []int{4,3,2,2}
	actual := questions.PlusOne(input)
	for i := 0; i < len(expected); i++ {
		assert.Equal(t, expected[i], actual[i])
	}
}