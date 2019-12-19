package tests

import (
	"gotest.tools/assert"
	"github.com/leetcode/questions"
	"testing"
)

func TestMergeSortedArray1(t *testing.T) {
	nums1 :=[]int{4,5,6,0,0,0}
	nums2 :=[]int{1,2,3}
	m,n := 3,3
	expected := []int{1,2,3,4,5,6}
	questions.Merge(nums1, m, nums2, n)
	for idx,val := range expected {
		assert.Equal(t, val, nums1[idx])
	}
}
