package tests

import (
	"gotest.tools/assert"
	"m/v2/questions"
	"testing"
)

func TestGroupThePeople(t *testing.T) {
	input := []int{3, 3, 3, 3, 3, 1, 3}
	expected := [][]int{
		{5},
		{0, 1, 2},
		{3, 4, 6},
	}
	actual := questions.GroupThePeople(input)
}
