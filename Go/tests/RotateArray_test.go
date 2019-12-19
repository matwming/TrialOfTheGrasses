package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestRotateArray(t *testing.T) {
	input:= []int{1,2,3,4,5,6,7}
	k := 3
	expected := []int{5,6,7,1,2,3,4}
	questions.Rotate(input, k)
	for i := 0; i < len(expected); i++ {
		assert.Equal(t, expected[i],input[i])
	}
}

func TestRotateArray2(t *testing.T) {
	input:= []int{1,2,3,4,5,6,7}
	k := 3
	expected := []int{5,6,7,1,2,3,4}
	questions.RotateInPlace(input, k)
	for i := 0; i < len(expected); i++ {
		assert.Equal(t, expected[i],input[i])
	}
}