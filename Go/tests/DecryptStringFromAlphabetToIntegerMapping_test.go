package tests

import (
	"github.com/leetcode/questions"
	"gotest.tools/assert"
	"testing"
)

func TestDecryptStringFromAlphabetToIntegerMapping1(t *testing.T) {
	s := "10#11#12"
	expected := "jkab"
	actual := questions.FreqAlphabets(s)
	assert.Equal(t, expected,actual)
}

func TestDecryptStringFromAlphabetToIntegerMapping2(t *testing.T) {
	s := "1326#"
	expected := "acz"
	actual := questions.FreqAlphabets(s)
	assert.Equal(t, expected,actual)
}

func TestDecryptStringFromAlphabetToIntegerMapping3(t *testing.T) {
	s := "12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#"
	expected := "abcdefghijklmnopqrstuvwxyz"
	actual := questions.FreqAlphabets(s)
	assert.Equal(t, expected,actual)
}