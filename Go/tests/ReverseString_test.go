package tests

import (
	"bytes"
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestReverString(t *testing.T) {
	s := []byte{'h','e','l','l','o'}
	expected :=[]byte{'o','l','l','e','h'}
	questions.ReverseString(s)
	assert.Assert(t, bytes.Compare(s,expected) ==0)
}
