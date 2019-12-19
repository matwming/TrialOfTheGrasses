package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestShift2DGrid(t *testing.T) {
	grid := [][]int{
		{1,2,3},
		{4,5,6},
		{7,8,9},
	}
	k := 1
	expected := [][]int{
		{9,1,2},
		{3,4,5},
		{6,7,8},
	}
	actual := questions.Shift2DGrid(grid,k)

	for i:= range expected {
		for j := range expected[i] {
			assert.Equal(t,expected[i][j], actual[i][j])
		}
	}
}
