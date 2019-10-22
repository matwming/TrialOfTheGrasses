> On the third day all the children died save one, a male barely ten. Hitherto agitated by a sudden madness, he fell at once into deep stupor. His eyes took on a glassy gaze, incessantly with his hands did he clutch at clothing, or brandish them in the air as if desirous of catching a quill. His breathing grew loud and hoarse; sweat cold, clammy and malodorous appeared on his skin. Then he was once more given elixir through the vein and the seizure it did return. This time a nose-bleed did ensue, coughing turned to vomiting, after which the male weakened entirely and became inert.
For two days more did symptoms not subside. The child's skin, hitherto drenched in sweat, grew dry and hot, the pulse ceased to be full and firm — albeit remaining of average strength, slow rather than fast. No more did he wake, nor did he scream.
Finally, came the seventh day. The male awoke and opened his eyes, and his eyes were those of a viper...                    

# Trial Of The Grasses
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/e2bc6c8566214a5892de7398beeb84a4)](https://app.codacy.com/app/user3301/Leetcode?utm_source=github.com&utm_medium=referral&utm_content=user3301/Leetcode&utm_campaign=Badge_Grade_Dashboard)
[![Build Status](https://travis-ci.org/user3301/TrialOfTheGrasses.svg?branch=master)](https://travis-ci.org/user3301/TrialOfTheGrasses)
[![codecov](https://codecov.io/gh/user3301/Leetcode/branch/master/graph/badge.svg)](https://codecov.io/gh/user3301/Leetcode)
[![solved/total](https://leetcode-badge.chyroc.cn/?name=user3301)](https://leetcode.com/user3301/)
[![Language](https://img.shields.io/badge/language-csharp-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](https://github.com/user3301/leetcodecsln/blob/master/LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)

:construction:My Leetcode algorithm question practice solution using C# (.Net Core) and tested with MSUnit. Hope it would help anyone with their technical interviews or inspires someone who is simply interested in algorithms just like me. 

## Table of contents
- [Trial Of The Grasses](#trial-of-the-grasses)
  - [Table of contents](#table-of-contents)
  - [Questions list](#questions-list)
  - [Algorithms](#algorithms)
    - [Two Pointers](#two-pointers)
    - [Sortings](#sortings)
    - [Strings](#strings)
    - [Array & Matrix](#array--matrix)
    - [Stack](#stack)
    - [HashTable & HashSet](#hashtable--hashset)

## Questions list
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 3 | :star: [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](./leetcodesln/LongestSubstringWithoutRepeatingCharacters.cs) | Medium | `Two Pointers`, `Sliding Window` | O(n) | O(1) |
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | [C#](./leetcodesln/ContainerWithMostWater.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 15| :star: [3Sum](https://leetcode.com/problems/3sum/) | [C#](./leetcodesln/ThreeSum.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 16 | [3Sum Closest](https://leetcode.com/problems/3sum-closest/) | [C#](./leetcodesln/ThreeSumClosest.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | [C#](./leetcodesln/RemoveElement.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 28 | [Implement strStr()](https://leetcode.com/problems/implement-strstr/) | [C#](./leetcodesln/ImplementStrStr.cs) | Easy | `Two Pointers`, :star:`KMP` | O(m*n) | O(1) | 
| 36 | :star:[Valid Suduku](https://leetcode.com/problems/valid-sudoku/) | [C#](./leetcodesln/ValidSudoku.cs) | Medium | `Hashtable` | O(81) | O(81*3) |
| 75 | :star: [Sort Colors](https://leetcode.com/problems/sort-colors/) | | Medium | `Two Pointers` | O(n) | O(1) | 
| 80 | :star: [Remove Duplicates from Sorted Array II](https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/) | [C#](./leetcodesln/RemoveDuplicatesFromSortedArrayII.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | [C#](./leetcodesln/MergeSortedArray.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | [C#](./leetcodesln/ValidPalindrome.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | [C#](./leetcodesln/LinkedListCycle.cs) | Easy | `Two Pointers`, `HashTable` | O(n) | O(1) |
| 167 | [Two Sum II - Input array is sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | [C#](./leetcodesln/TwoSumII.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 209 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | [C#](./leetcodesln/MinimumSizeSubarraySum.cs) | Medium | `Two Pointers`, `Sliding Window` | O(n) | O(1)|
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | [C#](./leetcodesln/KthLargestElementInAnArray.cs) | Medium | `Sorting`, `Priority Queue` | O(NLogK) | O(1) |
| 283 | [Move Zeroes](https://leetcode.com/problems/move-zeroes/) | [C#](./leetcodesln/MoveZeroes.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 299 | [Bulls and Cows](https://leetcode.com/problems/bulls-and-cows/) | [C#](./leetcodesln/BullsAndCows.cs) | Easy | `HashTable` | O(n) | O(n) |
| 344 | :white_check_mark:[Reverse String](https://leetcode.com/problems/reverse-string/) | [C#](./leetcodesln/ReverseString.cs) | Easy | `Two Pointers` | O(n) | O(n) | 
| 345 | [Reverse Vowels of a String](https://leetcode.com/problems/reverse-vowels-of-a-string/) | [C#](./leetcodesln/ReverseVowelsOfAString.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 347| [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | [C#](./leetcodesln/TopKFrequentElements.cs) | Medium | `Bucket Sort` | O(n) | O(n) |
| 349 | [Intersection of Two Arrays](https://leetcode.com/problems/intersection-of-two-arrays/) | [C#](./leetcodesln/IntersectionOfTwoArrays.cs) | Easy | `Two Pointers`, `HashSet` | O(n) | O(n) |
| 350 | [Intersection of Two Arrays II] | [C#](./leetcodesln/IntersectionOfTwoArrayII.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 424 | :star::star:[Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | [C#](./leetcodesln/LongestRepeatingCharacterReplacement.cs) | Medium | `Sliding Window`, `Two Pointers` | O(n) | O(26) | 
| 438 | :star: [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](./leetcodesln/FindAllAnagramsInAString.cs) | Medium | `Two Pointers`, `Sliding Window`, `HashTable` | O(n) | O(1) |
| 451 | [Sort Characters By Frequency](https://leetcode.com/problems/sort-characters-by-frequency/) | [C#](./leetcodesln/SortCharactersByFrequency.cs) | Medium | `Bucket Sort` | O(n) | O(n) |
| 457 | :star: [Circular Array Loop](https://leetcode.com/problems/circular-array-loop/) | [C#](./leetcodesln/CircularArrayLoop.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 481 | [Magical String](https://leetcode.com/problems/magical-string/) | [C#](./leetcodesln/MagicalString.cs) | Medium | `Two Pointers` | O(n) | O(n) | 
| 524 | [Longest Word in Dictionary through Deleting](https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/) | [C#](./leetcodesln/LongestWordInDictionaryThroughDeleting.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 532 | [K-diff Pairs in an Array](https://leetcode.com/problems/k-diff-pairs-in-an-array/) | [C#](./leetcodesln/K-DiffPairsInAnArray.cs) | Easy | `HashTable`, `Binary Search` | O(n), O(n) | O(n) ,O(1) | 
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](./leetcodesln/PermutationInString.cs) | Medium | `HashTable`, `Sliding Window`, `Two Pointers` | O(n) | O(n) | 
| 611 | :question:[ValidTriangleNumber](https://leetcode.com/problems/valid-triangle-number/) | [C#](./leetcodesln/ValidTriangleNumber.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 633 | [Sum of Square Numbers](https://leetcode.com/problems/sum-of-square-numbers/) | [C#](./leetcodesln/SumOfSquareNumbers.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 680 | [Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/) | [C#](./leetcodesln/ValidPalindromeII.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 713 | [Subarray Product Less Than K](https://leetcode.com/problems/subarray-product-less-than-k/) | [C#](./leetcodesln/SubarrayProductLessThanK.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 763 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | [C#](./leetcodesln/PartitionLabels.cs) | Medium | `Greedy`, `Sliding Window` | O(n) | O(26) | 
| 844 | [Backspace String Compare](https://leetcode.com/problems/backspace-string-compare/) | [C#](./leetcodesln/BackspaceStringCompare.cs) | Easy | `Stack`, :star:`Two Pointers` | O(n) | O(1) | 
| 904 | [Fruit Into Baskets](https://leetcode.com/problems/fruit-into-baskets/) | [C#](./leetcodesln/FruitIntoBaskets.cs) | Medium | `Two Pointers` | O(n) | O(2) |
| 925 | [Long Pressed Name](https://leetcode.com/problems/long-pressed-name/) | [C#](./leetcodesln/LongPressedName.cs) | Easy | `Two Pointers` | O(n) | O(1) |
|977 | :white_check_mark:[Squares Of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/) | [C#](./leetcodesln/SquaresOfASortedArray.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 986 | :star:[Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/) | [C#](./leetcodesln/IntervalListIntersections.cs) | Medium | `Two Pointers` | O(n) | O(n) |
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](./leetcodesln/FindCommonCharacters.cs) | Easy | `Array`, `HashTable` | O(26*26) | O(n) | 
| 1004 | [Max Consecutive Ones III](https://leetcode.com/problems/max-consecutive-ones-iii/) | [C#](./leetcodesln/MaxConsecutiveOnesIII.cs) | Medium | `Sliding Window` | O(n) | O(1) |
| 1200 | :white_check_mark:[Minimum Absolute Difference](https://leetcode.com/problems/minimum-absolute-difference/) | [C#](./leetcodesln/MinimumAbsoluteDifference.cs) | Easy | `Two Pointers` | O(nlogn + n) | O(1) |
| 1221 | :white_check_mark:[Split a String in Balanced Strings](https://leetcode.com/problems/split-a-string-in-balanced-strings/) | [C#](./leetcodesln/SplitAStringInBalancedStrings.cs) | Easy | `Stack`, `Greedy` | O(n) | O(n)| 
| 1222| :star:[Queens That Can Attack the King](https://leetcode.com/problems/queens-that-can-attack-the-king/) | [C#](./leetcodesln/QueensThatCanAttackTheKing.cs) | Medium | `Array` | O(1) | O(64) |

## Algorithms

### Two Pointers
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 3 | :star: [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](./leetcodesln/LongestSubstringWithoutRepeatingCharacters.cs) | Medium | `Two Pointers`, `Sliding Window` | O(n) | O(1) |
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | [C#](./leetcodesln/ContainerWithMostWater.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 15| :star: [3Sum](https://leetcode.com/problems/3sum/) | [C#](./leetcodesln/ThreeSum.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 16 | [3Sum Closest](https://leetcode.com/problems/3sum-closest/) | [C#](./leetcodesln/ThreeSumClosest.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | [C#](./leetcodesln/RemoveElement.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 28 | [Implement strStr()](https://leetcode.com/problems/implement-strstr/) | [C#](./leetcodesln/ImplementStrStr.cs) | Easy | `Two Pointers`, :star:`KMP` | O(m*n) | O(1) | 
| 75 | :star: [Sort Colors](https://leetcode.com/problems/sort-colors/) | [C#](./leetcodesln/SortColors.cs) | Medium | `Two Pointers` | O(n) | O(1) | 
| 80 | :star: [Remove Duplicates from Sorted Array II](https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/) | [C#](./leetcodesln/RemoveDuplicatesFromSortedArrayII.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | [C#](./leetcodesln/MergeSortedArray.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | [C#](./leetcodesln/ValidPalindrome.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | [C#](./leetcodesln/LinkedListCycle.cs) | Easy | `Two Pointers`, `HashTable` | O(n) | O(1) |
| 167 | [Two Sum II - Input array is sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | [C#](./leetcodesln/TwoSumII.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 209 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | [C#](./leetcodesln/MinimumSizeSubarraySum.cs) | Medium | `Two Pointers`,`Sliding Window` | O(n) | O(1)|
| 283 | [Move Zeroes](https://leetcode.com/problems/move-zeroes/) | [C#](./leetcodesln/MoveZeroes.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 344 | :white_check_mark:[Reverse String](https://leetcode.com/problems/reverse-string/) | [C#](./leetcodesln/ReverseString.cs) | Easy | `Two Pointers` | O(n) | O(n) | 
| 345 | [Reverse Vowels of a String](https://leetcode.com/problems/reverse-vowels-of-a-string/) | [C#](./leetcodesln/ReverseVowelsOfAString.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 350 | [Intersection of Two Arrays II](https://leetcode.com/problems/intersection-of-two-arrays-ii/) | [C#](./leetcodesln/IntersectionOfTwoArrayII.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 349 | [Intersection of Two Arrays](https://leetcode.com/problems/intersection-of-two-arrays/) | [C#](./leetcodesln/IntersectionOfTwoArrays.cs) | Easy | `Two Pointers`, `HashSet` | O(n) | O(n) |
| 424 | :star::star:[Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | [C#](./leetcodesln/LongestRepeatingCharacterReplacement.cs) | Medium | `Sliding Window`, `Two Pointers` | O(n) | O(26) | 
| 438 | :star: [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](./leetcodesln/FindAllAnagramsInAString.cs) | Medium | `Two Pointers`, `Sliding Window`, `HashTable` | O(n) | O(1) |
| 457 | :star: [Circular Array Loop](https://leetcode.com/problems/circular-array-loop/) | [C#](./leetcodesln/CircularArrayLoop.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 481 | [Magical String](https://leetcode.com/problems/magical-string/) | [C#](./leetcodesln/MagicalString.cs) | Medium | `Two Pointers` | O(n) | O(n) | 
| 524 | [Longest Word in Dictionary through Deleting](https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/) | [C#](./leetcodesln/LongestWordInDictionaryThroughDeleting.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 532 | [K-diff Pairs in an Array](https://leetcode.com/problems/k-diff-pairs-in-an-array/) | [C#](./leetcodesln/K-DiffPairsInAnArray.cs) | Easy | `HashTable`, `Binary Search` | O(n), O(n) | O(n) ,O(1) | 
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](./leetcodesln/PermutationInString.cs) | Medium | `HashTable`, `Sliding Window`, `Two Pointers` | O(n) | O(n) | 
| 611 | :question:[ValidTriangleNumber](https://leetcode.com/problems/valid-triangle-number/) | [C#](./leetcodesln/ValidTriangleNumber.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 633 | [Sum of Square Numbers](https://leetcode.com/problems/sum-of-square-numbers/) | [C#](./leetcodesln/SumOfSquareNumbers.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 680 | [Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/) | [C#](./leetcodesln/ValidPalindromeII.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 713 | [Subarray Product Less Than K](https://leetcode.com/problems/subarray-product-less-than-k/) | [C#](./leetcodesln/SubarrayProductLessThanK.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 763 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | [C#](./leetcodesln/PartitionLabels.cs) | Medium | `Greedy`, `Sliding Window` | O(n) | O(26) | 
| 844 | [Backspace String Compare](https://leetcode.com/problems/backspace-string-compare/) | [C#](./leetcodesln/BackspaceStringCompare.cs) | Easy | `Stack`, :star:`Two Pointers` | O(n) | O(1) | 
| 904 | [Fruit Into Baskets](https://leetcode.com/problems/fruit-into-baskets/) | [C#](./leetcodesln/FruitIntoBaskets.cs) | Medium | `Two Pointers` | O(n) | O(2) |
| 925 | [Long Pressed Name](https://leetcode.com/problems/long-pressed-name/) | [C#](./leetcodesln/LongPressedName.cs) | Easy | `Two Pointers` | O(n) | O(1) |
|977 | :white_check_mark:[Squares Of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/) | [C#](./leetcodesln/SquaresOfASortedArray.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 986 | :star:[Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/) | [C#](./leetcodesln/IntervalListIntersections.cs) | Medium | `Two Pointers` | O(n) | O(n) |
| 1004 | [Max Consecutive Ones III](https://leetcode.com/problems/max-consecutive-ones-iii/) | [C#](./leetcodesln/MaxConsecutiveOnesIII.cs) | Medium | `Sliding Window` | O(n) | O(1) |
| 1200 | :white_check_mark:[Minimum Absolute Difference](https://leetcode.com/problems/minimum-absolute-difference/) | [C#](./leetcodesln/MinimumAbsoluteDifference.cs) | Easy | `Two Pointers` | O(nlogn + n) | O(1) | 

### Sortings
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | [C#](./leetcodesln/KthLargestElementInAnArray.cs) | Medium | `Sorting`, `Priority Queue` | O(NLogK) | O(1) |
| 347| [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | [C#](./leetcodesln/TopKFrequentElements.cs) | Medium | `Bucket Sort` | O(n) | O(n) |
| 451 | [Sort Characters By Frequency](https://leetcode.com/problems/sort-characters-by-frequency/) | [C#](./leetcodesln/SortCharactersByFrequency.cs) | Medium | `Bucket Sort` | O(n) | O(n) |


### Strings
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 1221 | :white_check_mark:[Split a String in Balanced Strings](https://leetcode.com/problems/split-a-string-in-balanced-strings/) | [C#](./leetcodesln/SplitAStringInBalancedStrings.cs) | Easy | `Stack`, `Greedy` | O(n) | O(n)| 

### Array & Matrix
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](./leetcodesln/FindCommonCharacters.cs) | Easy | `Array`, `HashTable` | O(26*26) | O(n) |
| 1222| :star:[Queens That Can Attack the King](https://leetcode.com/problems/queens-that-can-attack-the-king/) | [C#](./leetcodesln/QueensThatCanAttackTheKing.cs) | Medium | `Array` | O(1) | O(64) |

### Stack
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 844 | [Backspace String Compare](https://leetcode.com/problems/backspace-string-compare/) | [C#](./leetcodesln/BackspaceStringCompare.cs) | Easy | `Stack`, :star:`Two Pointers` | O(n) | O(1) | 

### HashTable & HashSet
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](./leetcodesln/TwoSum.cs) | Easy | `Two Pointers`, `Hashtable` | O(n), O(n) | O(1), O(n) |
| 36 | :star:[Valid Suduku](https://leetcode.com/problems/valid-sudoku/) | [C#](./leetcodesln/ValidSudoku.cs) | Medium | `Hashtable` | O(81) | O(81*3) |
| 299 | [Bulls and Cows](https://leetcode.com/problems/bulls-and-cows/) | [C#](./leetcodesln/BullsAndCows.cs) | Easy | `HashTable` | O(n) | O(n) |
| 438 | :star: [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](./leetcodesln/FindAllAnagramsInAString.cs) | Medium | `Two Pointers`, `Sliding Window`, `HashTable` | O(n) | O(1) |
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](./leetcodesln/PermutationInString.cs) | Medium | `HashTable`, `Sliding Window`, `Two Pointers` | O(n) | O(n) | 
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](./leetcodesln/FindCommonCharacters.cs) | Easy | `Array`, `HashTable` | O(26*26) | O(n) |