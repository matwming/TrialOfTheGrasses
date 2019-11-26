> On the third day all the children died save one, a male barely ten. Hitherto agitated by a sudden madness, he fell at once into deep stupor. His eyes took on a glassy gaze, incessantly with his hands did he clutch at clothing, or brandish them in the air as if desirous of catching a quill. His breathing grew loud and hoarse; sweat cold, clammy and malodorous appeared on his skin. Then he was once more given elixir through the vein and the seizure it did return. This time a nose-bleed did ensue, coughing turned to vomiting, after which the male weakened entirely and became inert.
For two days more did symptoms not subside. The child's skin, hitherto drenched in sweat, grew dry and hot, the pulse ceased to be full and firm — albeit remaining of average strength, slow rather than fast. No more did he wake, nor did he scream.
Finally, came the seventh day. The male awoke and opened his eyes, and his eyes were those of a viper...                    

# Trial Of The Grasses
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/e2bc6c8566214a5892de7398beeb84a4)](https://app.codacy.com/app/user3301/Leetcode?utm_source=github.com&utm_medium=referral&utm_content=user3301/Leetcode&utm_campaign=Badge_Grade_Dashboard)
[![Build Status](https://travis-ci.org/user3301/TrialOfTheGrasses.svg?branch=master)](https://travis-ci.org/user3301/TrialOfTheGrasses)
[![solved/total](https://leetcode-badge.chyroc.cn/?name=user3301)](https://leetcode.com/user3301/)
[![Language](https://img.shields.io/badge/language-csharp-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](https://github.com/user3301/leetcodecsln/blob/master/LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)

:construction:My Leetcode algorithm question practice solution using a variety of programming languages. Hope it would help anyone with their technical interviews or inspires someone who is simply interested in algorithms just like me. 

## Table of contents
- [Trial Of The Grasses](#trial-of-the-grasses)
  - [Table of contents](#table-of-contents)
  - [Questions list](#questions-list)
  - [Algorithms](#algorithms)
    - [Two Pointers](#two-pointers)
    - [Binary Search](#binary-search)
    - [Sortings](#sortings)
    - [Strings](#strings)
    - [Array & Matrix](#array--matrix)
    - [Stack](#stack)
    - [HashTable & HashSet](#hashtable--hashset)
    - [Dynamic Programming](#dynamic-programming)
    - [Backtracking](#backtracking)

## Questions list
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](./CSharp/leetcodesln/TwoSum.cs) [Go](./Go/questions/TwoSum.go) | Easy | `Hashtable` | O(n) | O(n)| 
| 3 | :star: [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](./CSharp/leetcodesln/LongestSubstringWithoutRepeatingCharacters.cs) | Medium | `Two Pointers`, `Sliding Window` | O(n) | O(1) |
| 6 | :star:[ZigZag Conversion](https://leetcode.com/problems/zigzag-conversion/) | [C#](./CSharp/leetcodesln/ZigZagConversion.cs) | Medium | `String` | O(n), O(n) | O(n), O(n) |
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | [C#](./CSharp/leetcodesln/ContainerWithMostWater.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 14 | :star:[Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/) | [C#](./CSharp/leetcodesln/LongestCommonPrefix.cs) | Easy | `String` | O(m*n) | O(1)| 
| 15| :star: [3Sum](https://leetcode.com/problems/3sum/) | [C#](./CSharp/leetcodesln/ThreeSum.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 16 | [3Sum Closest](https://leetcode.com/problems/3sum-closest/) | [C#](./CSharp/leetcodesln/ThreeSumClosest.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 18 | [4Sum](https://leetcode.com/problems/4sum/) | [C#](./CSharp/leetcodesln/FourSum.cs) | Medium | `Binary Search`, `Two Pointers` | O(n^2 + n^3) | O(1) | 
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | [C#](./CSharp/leetcodesln/RemoveElement.cs) [Go](./Go/questions/RemoveElement.go) | Easy | `Two Pointers` | O(n) | O(1) | 
| 28 | [Implement strStr()](https://leetcode.com/problems/implement-strstr/) | [C#](./CSharp/leetcodesln/ImplementStrStr.cs) | Easy | `Two Pointers`, :star:`KMP` | O(m*n) | O(1) | 
| 33 | :star:[Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | [C#](./CSharp/leetcodesln/SearchInRotatedSortedArray.cs) | Medium | `Binary Search` | O(Logn) | O(1) | 
| 34 | [Find First and Last Position of Element in Sorted Array](https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/) | [C#](./CSharp/leetcodesln/FindFirstAndLastPositionOfElementInSortArray.cs) | Medium |`Binary Search`|  O(logn) | O(1) |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | [C#](./CSharp/leetcodesln/SearchInsertPosition.cs) | Medium | `Binary Search` | O(logn) | O(1) |
| 36 | :star:[Valid Suduku](https://leetcode.com/problems/valid-sudoku/) | [C#](./CSharp/leetcodesln/ValidSudoku.cs) | Medium | `Hashtable` | O(81) | O(81*3) |
| 39 | :star: [Combination Sum](https://leetcode.com/problems/combination-sum/) | [C#](./CSharp/leetcodesln/CombinationSum.cs) | Medium | `Backtracking` | O(2^n) | O(n) |
| 48 | [Rotate Image](https://leetcode.com/problems/rotate-image/) | [C#](./CSharp/leetcodesln/RotateImage.cs) | Medium | `Array`, `Two Pointers` | O(n) | O(1) | 
| 50 | [Pow(x,n)](https://leetcode.com/problems/powx-n/) | [C#](./CSharp/leetcodesln/PowX_N.cs) | Medium | `Binary Search`, `Recursion` | O(logn) | O(1) |
| 66 | [Plus One](https://leetcode.com/problems/plus-one/) | [C#](./CSharp/leetcodesln/PlusOne.cs) [Go](./Go/questions/PlusOne.go) | Easy | `Array` | O(n) | O(1) | 
| 69 | [Sqrt(x)](https://leetcode.com/problems/sqrtx/) | [C#](./CSharp/leetcodesln/Sqrt(x).cs) | Easy | `Binary Search` | O(logn) | O(1) | 
| 75 | :star: [Sort Colors](https://leetcode.com/problems/sort-colors/) | [C#](./CSharp/leetcodesln/SortColors.cs) | Medium | `Two Pointers` | O(n) | O(1) | 
| 76 | [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) | [C#](./CSharp/leetcodesln/MinimumWindowSubstring.cs) | Hard | `Sliding Window`, `HashTable` | O(n) | O(n) | 
| 80 | :star: [Remove Duplicates from Sorted Array II](https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/) | [C#](./CSharp/leetcodesln/RemoveDuplicatesFromSortedArrayII.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | [C#](./CSharp/leetcodesln/MergeSortedArray.cs) [Go](Go/questions/MergeSortedArray.go) | Easy | `Two Pointers` | O(n) | O(1) |  
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | [C#](./CSharp/leetcodesln/ValidPalindrome.cs) [Go](Go/questions/ValidPalindrome.go) | Easy | `Two Pointers` | O(n) | O(1) |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | [C#](./CSharp/leetcodesln/LinkedListCycle.cs) | Easy | `Two Pointers`, `HashTable` | O(n) | O(1) |
| 167 | [Two Sum II - Input array is sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | [C#](./CSharp/leetcodesln/TwoSumII.cs) [Go](Go/questions/TwoSumII.go) | Easy | `Two Pointers` | O(n) | O(1) |
| 169 | [Majority Element](https://leetcode.com/problems/majority-element/) | [C#](./CSharp/leetcodesln/MajorityElement.cs) [Go](Go/questions/MajorityElement.go)| Easy | `Array`, `Boyer-Moore Voting Algorithm`, `Bit Manipulation` | O(n) | O(1) | 
| 209 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | [C#](./CSharp/leetcodesln/MinimumSizeSubarraySum.cs) | Medium | `Two Pointers`, `Sliding Window` | O(n) | O(1)|
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | [C#](./CSharp/leetcodesln/KthLargestElementInAnArray.cs) | Medium | `Sorting`, `Priority Queue` | O(NLogK) | O(1) |
| 228 | [Summary Ranges](https://leetcode.com/problems/summary-ranges/) | [C#](./CSharp/leetcodesln/SummaryRanges.cs) | Medium | `Array`, `Two Pointers` | O(n) | O(n) | 
| 229 | [Majority Element II](https://leetcode.com/problems/majority-element-ii/) | [C#](./CSharp/leetcodesln/MajorityElementII.cs) | Medium | `Array`, `Boyer-Moore Voting Algorithm` | O(n) | O(1) | 
| 238 | [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | [C#](./CSharp/leetcodesln/ProductOfArrayExceptSelf.cs) | Medium | `Array`, `Prefix Caching` | O(n) | O(n) |
| 283 | :star:[Move Zeroes](https://leetcode.com/problems/move-zeroes/) | [C#](./CSharp/leetcodesln/MoveZeroes.cs) [Go](Go/questions/MoveZeroes.go) | Easy | `Two Pointers`, `Array` | O(n) | O(1) |
| 299 | [Bulls and Cows](https://leetcode.com/problems/bulls-and-cows/) | [C#](./CSharp/leetcodesln/BullsAndCows.cs) | Easy | `HashTable` | O(n) | O(n) |
| 344 | :white_check_mark:[Reverse String](https://leetcode.com/problems/reverse-string/) | [C#](./CSharp/leetcodesln/ReverseString.cs) [Go](Go/questions/ReverseString.go) | Easy | `Two Pointers` | O(n) | O(n) | 
| 345 | [Reverse Vowels of a String](https://leetcode.com/problems/reverse-vowels-of-a-string/) | [C#](./CSharp/leetcodesln/ReverseVowelsOfAString.cs) [Go](/Go/questions/ReverseVowelsOfAString.go) | Easy | `Two Pointers` | O(n) | O(1) |
| 347| [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | [C#](./CSharp/leetcodesln/TopKFrequentElements.cs) | Medium | `Bucket Sort` | O(n) | O(n) |
| 349 | [Intersection of Two Arrays](https://leetcode.com/problems/intersection-of-two-arrays/) | [C#](./CSharp/leetcodesln/IntersectionOfTwoArrays.cs) [Go](./Go/tests/IntersectionOfTwoArrays_test.go) | Easy | `Two Pointers`, `HashSet` | O(n) | O(n) |
| 350 | [Intersection of Two Arrays II](https://leetcode.com/problems/intersection-of-two-arrays-ii/) | [C#](./CSharp/leetcodesln/IntersectionOfTwoArraysII.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 424 | :star::star:[Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | [C#](./CSharp/leetcodesln/LongestRepeatingCharacterReplacement.cs) | Medium | `Sliding Window`, `Two Pointers` | O(n) | O(26) | 
| 438 | :star: [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](./CSharp/leetcodesln/FindAllAnagramsInAString.cs) | Medium | `Two Pointers`, `Sliding Window`, `HashTable` | O(n) | O(1) |
| 442 | [Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/) | [C#](./CSharp/leetcodesln/FindAllDuplicatesInAnArray.cs) | Medium | `Two Pointers`, `Array` | O(n) | O(1) |
| 451 | [Sort Characters By Frequency](https://leetcode.com/problems/sort-characters-by-frequency/) | [C#](./CSharp/leetcodesln/SortCharactersByFrequency.cs) | Medium | `Bucket Sort` | O(n) | O(n) |
| 457 | :star: [Circular Array Loop](https://leetcode.com/problems/circular-array-loop/) | [C#](./CSharp/leetcodesln/CircularArrayLoop.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 481 | [Magical String](https://leetcode.com/problems/magical-string/) | [C#](./CSharp/leetcodesln/MagicalString.cs) | Medium | `Two Pointers` | O(n) | O(n) | 
| 524 | [Longest Word in Dictionary through Deleting](https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/) | [C#](./CSharp/leetcodesln/LongestWordInDictionaryThroughDeleting.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 532 | [K-diff Pairs in an Array](https://leetcode.com/problems/k-diff-pairs-in-an-array/) | [C#](./CSharp/leetcodesln/K-DiffPairsInAnArray.cs) | Easy | `HashTable`, `Binary Search` | O(n), O(n) | O(n) ,O(1) | 
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](./CSharp/leetcodesln/PermutationInString.cs) | Medium | `HashTable`, `Sliding Window`, `Two Pointers` | O(n) | O(n) | 
| 611 | :question:[ValidTriangleNumber](https://leetcode.com/problems/valid-triangle-number/) | [C#](./CSharp/leetcodesln/ValidTriangleNumber.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 633 | [Sum of Square Numbers](https://leetcode.com/problems/sum-of-square-numbers/) | [C#](./CSharp/leetcodesln/SumOfSquareNumbers.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 680 | [Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/) | [C#](./CSharp/leetcodesln/ValidPalindromeII.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 713 | [Subarray Product Less Than K](https://leetcode.com/problems/subarray-product-less-than-k/) | [C#](./CSharp/leetcodesln/SubarrayProductLessThanK.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 763 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | [C#](./CSharp/leetcodesln/PartitionLabels.cs) | Medium | `Greedy`, `Sliding Window` | O(n) | O(26) | 
| 844 | [Backspace String Compare](https://leetcode.com/problems/backspace-string-compare/) | [C#](./CSharp/leetcodesln/BackspaceStringCompare.cs) | Easy | `Stack`, :star:`Two Pointers` | O(n) | O(1) | 
| 904 | [Fruit Into Baskets](https://leetcode.com/problems/fruit-into-baskets/) | [C#](./CSharp/leetcodesln/FruitIntoBaskets.cs) | Medium | `Two Pointers` | O(n) | O(2) |
| 925 | [Long Pressed Name](https://leetcode.com/problems/long-pressed-name/) | [C#](./CSharp/leetcodesln/LongPressedName.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 950 | [Reveal Cards In Increasing Order](https://leetcode.com/problems/reveal-cards-in-increasing-order/) | [C#](./CSharp/leetcodesln/RevealCardsInIncreasingOrder.cs) | Medium | `Array`, :star:`Queue` | O(n) | O(n) |
| 961 | [N-Repeated Element in Size 2N Array](https://leetcode.com/problems/n-repeated-element-in-size-2n-array/) | [C#](./CSharp/leetcodesln/N-RepeatedElementInSize2NArray.cs) | Easy | `Hashtable`, `Array` | O(n) | O(n) |
|977 | :white_check_mark:[Squares Of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/) | [C#](./CSharp/leetcodesln/SquaresOfASortedArray.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 985 | :star: [Sum of Even Numbers After Queries](https://leetcode.com/problems/sum-of-even-numbers-after-queries/) | [C#](./CSharp/leetcodesln/SumOfEvenNumbersAfterQueries.cs) | Easy | `Array`, `Prefix Caching` | O(n) | O(n) |
| 986 | :star:[Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/) | [C#](./CSharp/leetcodesln/IntervalListIntersections.cs) | Medium | `Two Pointers` | O(n) | O(n) |
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](./CSharp/leetcodesln/FindCommonCharacters.cs) | Easy | `Array`, `HashTable` | O(26*26) | O(n) | 
| 1004 | [Max Consecutive Ones III](https://leetcode.com/problems/max-consecutive-ones-iii/) | [C#](./CSharp/leetcodesln/MaxConsecutiveOnesIII.cs) | Medium | `Sliding Window` | O(n) | O(1) |
| 1200 | :white_check_mark:[Minimum Absolute Difference](https://leetcode.com/problems/minimum-absolute-difference/) | [C#](./CSharp/leetcodesln/MinimumAbsoluteDifference.cs) | Easy | `Two Pointers` | O(nlogn + n) | O(1) |
| 1221 | :white_check_mark:[Split a String in Balanced Strings](https://leetcode.com/problems/split-a-string-in-balanced-strings/) | [C#](./CSharp/leetcodesln/SplitAStringInBalancedStrings.cs) | Easy | `Stack`, `Greedy` | O(n) | O(n)| 
| 1222| :star:[Queens That Can Attack the King](https://leetcode.com/problems/queens-that-can-attack-the-king/) | [C#](./CSharp/leetcodesln/QueensThatCanAttackTheKing.cs) | Medium | `Array` | O(1) | O(64) |

## Algorithms

### Two Pointers
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 3 | :star: [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](./CSharp/leetcodesln/LongestSubstringWithoutRepeatingCharacters.cs) | Medium | `Two Pointers`, `Sliding Window` | O(n) | O(1) |
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | [C#](./CSharp/leetcodesln/ContainerWithMostWater.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 15| :star: [3Sum](https://leetcode.com/problems/3sum/) | [C#](./CSharp/leetcodesln/ThreeSum.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 16 | [3Sum Closest](https://leetcode.com/problems/3sum-closest/) | [C#](./CSharp/leetcodesln/ThreeSumClosest.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 18 | [4Sum](https://leetcode.com/problems/4sum/) | [C#](./CSharp/leetcodesln/FourSum.cs) | Medium | `Binary Search`, `Two Pointers` | O(n^2 + n^3) | O(1) | 
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | [C#](./CSharp/leetcodesln/RemoveElement.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 28 | [Implement strStr()](https://leetcode.com/problems/implement-strstr/) | [C#](./CSharp/leetcodesln/ImplementStrStr.cs) | Easy | `Two Pointers`, :star:`KMP` | O(m*n) | O(1) | 
| 48 | [Rotate Image](https://leetcode.com/problems/rotate-image/) | [C#](./CSharp/leetcodesln/RotateImage.cs) | Medium | `Array`, `Two Pointers` | O(n) | O(1) | 
| 75 | :star: [Sort Colors](https://leetcode.com/problems/sort-colors/) | [C#](./CSharp/leetcodesln/SortColors.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 76 | [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) | [C#](./CSharp/leetcodesln/MinimumWindowSubstring.cs) | Hard | `Sliding Window`, `HashTable` | O(n) | O(n) | 
| 80 | :star: [Remove Duplicates from Sorted Array II](https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/) | [C#](./CSharp/leetcodesln/RemoveDuplicatesFromSortedArrayII.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | [C#](./CSharp/leetcodesln/MergeSortedArray.cs) [Go](Go/questions/MergeSortedArray.go) | Easy | `Two Pointers` | O(n) | O(1) | 
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | [C#](./CSharp/leetcodesln/ValidPalindrome.cs) [Go](Go/questions/ValidPalindrome.go) | Easy | `Two Pointers` | O(n) | O(1) |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | [C#](./CSharp/leetcodesln/LinkedListCycle.cs) | Easy | `Two Pointers`, `HashTable` | O(n) | O(1) |
| 167 | [Two Sum II - Input array is sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | [C#](./CSharp/leetcodesln/TwoSumII.cs) [Go](Go/questions/TwoSumII.go) | Easy | `Two Pointers` | O(n) | O(1) |
| 209 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | [C#](./CSharp/leetcodesln/MinimumSizeSubarraySum.cs) | Medium | `Two Pointers`,`Sliding Window` | O(n) | O(1)|
| 228 | [Summary Ranges](https://leetcode.com/problems/summary-ranges/) | [C#](./CSharp/leetcodesln/SummaryRanges.cs) | Medium | `Array`, `Two Pointers` | O(n) | O(n) | 
| 283 | :star:[Move Zeroes](https://leetcode.com/problems/move-zeroes/) | [C#](./CSharp/leetcodesln/MoveZeroes.cs) [Go](Go/questions/MoveZeroes.go) | Easy | `Two Pointers`, `Array` | O(n) | O(1) |
| 344 | :white_check_mark:[Reverse String](https://leetcode.com/problems/reverse-string/) | [C#](./CSharp/leetcodesln/ReverseString.cs) [Go](Go/questions/ReverseString.go) | Easy | `Two Pointers` | O(n) | O(n) | 
| 345 | [Reverse Vowels of a String](https://leetcode.com/problems/reverse-vowels-of-a-string/) | [C#](./CSharp/leetcodesln/ReverseVowelsOfAString.cs) [Go](/Go/questions/ReverseVowelsOfAString.go) | Easy | `Two Pointers` | O(n) | O(1) |
| 349 | [Intersection of Two Arrays](https://leetcode.com/problems/intersection-of-two-arrays/) | [C#](./CSharp/leetcodesln/IntersectionOfTwoArrays.cs) [Go](./Go/tests/IntersectionOfTwoArrays_test.go) | Easy | `Two Pointers`, `HashSet` | O(n) | O(n) |
| 350 | [Intersection of Two Arrays II](https://leetcode.com/problems/intersection-of-two-arrays-ii/) | [C#](./CSharp/leetcodesln/IntersectionOfTwoArrayII.cs) [Go](Go/questions/IntersectionOfTwoArraysII.go) | Easy | `Two Pointers` | O(n) | O(n) |
| 424 | :star::star:[Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | [C#](./CSharp/leetcodesln/LongestRepeatingCharacterReplacement.cs) | Medium | `Sliding Window`, `Two Pointers` | O(n) | O(26) | 
| 438 | :star: [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](./CSharp/leetcodesln/FindAllAnagramsInAString.cs) | Medium | `Two Pointers`, `Sliding Window`, `HashTable` | O(n) | O(1) |
| 442 | [Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/) | [C#](./CSharp/leetcodesln/FindAllDuplicatesInAnArray.cs) | Medium | `Two Pointers`, `Array` | O(n) | O(1) |
| 457 | :star: [Circular Array Loop](https://leetcode.com/problems/circular-array-loop/) | [C#](./CSharp/leetcodesln/CircularArrayLoop.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 481 | [Magical String](https://leetcode.com/problems/magical-string/) | [C#](./CSharp/leetcodesln/MagicalString.cs) | Medium | `Two Pointers` | O(n) | O(n) | 
| 524 | [Longest Word in Dictionary through Deleting](https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/) | [C#](./CSharp/leetcodesln/LongestWordInDictionaryThroughDeleting.cs) | Medium | `Two Pointers` | O(n^2) | O(1) |
| 532 | [K-diff Pairs in an Array](https://leetcode.com/problems/k-diff-pairs-in-an-array/) | [C#](./CSharp/leetcodesln/K-DiffPairsInAnArray.cs) | Easy | `HashTable`, `Binary Search` | O(n), O(n) | O(n) ,O(1) | 
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](./CSharp/leetcodesln/PermutationInString.cs) | Medium | `HashTable`, `Sliding Window`, `Two Pointers` | O(n) | O(n) | 
| 611 | :question:[ValidTriangleNumber](https://leetcode.com/problems/valid-triangle-number/) | [C#](./CSharp/leetcodesln/ValidTriangleNumber.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 633 | [Sum of Square Numbers](https://leetcode.com/problems/sum-of-square-numbers/) | [C#](./CSharp/leetcodesln/SumOfSquareNumbers.cs) | Easy | `Two Pointers` | O(n) | O(1) |
| 680 | [Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/) | [C#](./CSharp/leetcodesln/ValidPalindromeII.cs) | Easy | `Two Pointers` | O(n) | O(1) | 
| 713 | [Subarray Product Less Than K](https://leetcode.com/problems/subarray-product-less-than-k/) | [C#](./CSharp/leetcodesln/SubarrayProductLessThanK.cs) | Medium | `Two Pointers` | O(n) | O(1) |
| 763 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | [C#](./CSharp/leetcodesln/PartitionLabels.cs) | Medium | `Greedy`, `Sliding Window` | O(n) | O(26) | 
| 844 | [Backspace String Compare](https://leetcode.com/problems/backspace-string-compare/) | [C#](./CSharp/leetcodesln/BackspaceStringCompare.cs) | Easy | `Stack`, :star:`Two Pointers` | O(n) | O(1) | 
| 904 | [Fruit Into Baskets](https://leetcode.com/problems/fruit-into-baskets/) | [C#](./CSharp/leetcodesln/FruitIntoBaskets.cs) | Medium | `Two Pointers` | O(n) | O(2) |
| 925 | [Long Pressed Name](https://leetcode.com/problems/long-pressed-name/) | [C#](./CSharp/leetcodesln/LongPressedName.cs) | Easy | `Two Pointers` | O(n) | O(1) |
|977 | :white_check_mark:[Squares Of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/) | [C#](./CSharp/leetcodesln/SquaresOfASortedArray.cs) | Easy | `Two Pointers` | O(n) | O(n) |
| 986 | :star:[Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/) | [C#](./CSharp/leetcodesln/IntervalListIntersections.cs) | Medium | `Two Pointers` | O(n) | O(n) |
| 1004 | [Max Consecutive Ones III](https://leetcode.com/problems/max-consecutive-ones-iii/) | [C#](./CSharp/leetcodesln/MaxConsecutiveOnesIII.cs) | Medium | `Sliding Window` | O(n) | O(1) |
| 1200 | :white_check_mark:[Minimum Absolute Difference](https://leetcode.com/problems/minimum-absolute-difference/) | [C#](./CSharp/leetcodesln/MinimumAbsoluteDifference.cs) | Easy | `Two Pointers` | O(nlogn + n) | O(1) | 

### Binary Search
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 33 | :star:[Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | [C#](./CSharp/leetcodesln/SearchInRotatedSortedArray.cs) | Medium | `Binary Search` | O(Logn) | O(1) | 
| 34 | [Find First and Last Position of Element in Sorted Array](https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/) | [C#](./CSharp/leetcodesln/FindFirstAndLastPositionOfElementInSortArray.cs) | Medium |`Binary Search`|  O(logn) | O(1) |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | [C#](./CSharp/leetcodesln/SearchInsertPosition.cs) | Medium | `Binary Search` | O(logn) | O(1) |
| 50 | [Pow(x,n)](https://leetcode.com/problems/powx-n/) | [C#](./CSharp/leetcodesln/PowX_N.cs) | Medium | `Binary Search`, `Recursion` | O(logn) | O(1) |
| 69 | [Sqrt(x)](https://leetcode.com/problems/sqrtx/) | [C#](./CSharp/leetcodesln/Sqrt(x).cs) | Easy | `Binary Search` | O(logn) | O(1) | 

### Sortings
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | [C#](./CSharp/leetcodesln/KthLargestElementInAnArray.cs) | Medium | `Sorting`, `Priority Queue` | O(NLogK) | O(1) |
| 347| [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | [C#](./CSharp/leetcodesln/TopKFrequentElements.cs) | Medium | `Bucket Sort` | O(n) | O(n) |
| 451 | [Sort Characters By Frequency](https://leetcode.com/problems/sort-characters-by-frequency/) | [C#](./CSharp/leetcodesln/SortCharactersByFrequency.cs) | Medium | `Bucket Sort` | O(n) | O(n) |


### Strings
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 6 | :star:[ZigZag Conversion](https://leetcode.com/problems/zigzag-conversion/) | [C#](./CSharp/leetcodesln/ZigZagConversion.cs) | Medium | `String` | O(n), O(n) | O(n), O(n) |
| 14 | :star:[Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/) | [C#](./CSharp/leetcodesln/LongestCommonPrefix.cs) | Easy | `String` | O(m*n) | O(1)|
| 1221 | :white_check_mark:[Split a String in Balanced Strings](https://leetcode.com/problems/split-a-string-in-balanced-strings/) | [C#](./CSharp/leetcodesln/SplitAStringInBalancedStrings.cs) | Easy | `Stack`, `Greedy` | O(n) | O(n)| 

### Array & Matrix
Prefix-caching can solve many subarray related problems.

| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 48 | [Rotate Image](https://leetcode.com/problems/rotate-image/) | [C#](./CSharp/leetcodesln/RotateImage.cs) | Medium | `Array`, `Two Pointers` | O(n) | O(1) | 
| 66 | [Plus One](https://leetcode.com/problems/plus-one/) | [C#](./CSharp/leetcodesln/PlusOne.cs) [Go](./Go/questions/PlusOne.go) | Easy | `Array` | O(n) | O(1) | 
| 169 | [Majority Element](https://leetcode.com/problems/majority-element/) | [C#](./CSharp/leetcodesln/MajorityElement.cs) [Go](Go/questions/MajorityElement.go)| Easy | `Array`, `Boyer-Moore Voting Algorithm`, `Bit Manipulation` | O(n) | O(1) | 
| 228 | [Summary Ranges](https://leetcode.com/problems/summary-ranges/) | [C#](./CSharp/leetcodesln/SummaryRanges.cs) | Medium | `Array`, `Two Pointers` | O(n) | O(n) | 
| 229 | [Majority Element II](https://leetcode.com/problems/majority-element-ii/) | [C#](./CSharp/leetcodesln/MajorityElementII.cs) | Medium | `Array`, `Boyer-Moore Voting Algorithm` | O(n) | O(1) | 
| 238 | [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | [C#](./CSharp/leetcodesln/ProductOfArrayExceptSelf.cs) | Medium | `Array`, `Prefix Caching` | O(n) | O(n) |
| 283 | :star:[Move Zeroes](https://leetcode.com/problems/move-zeroes/) | [C#](./CSharp/leetcodesln/MoveZeroes.cs) [Go](Go/questions/MoveZeroes.go) | Easy | `Two Pointers`, `Array` | O(n) | O(1) |
| 442 | [Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/) | [C#](./CSharp/leetcodesln/FindAllDuplicatesInAnArray.cs) | Medium | `Two Pointers`, `Array` | O(n) | O(1) |
| 950 | [Reveal Cards In Increasing Order](https://leetcode.com/problems/reveal-cards-in-increasing-order/) | [C#](./CSharp/leetcodesln/RevealCardsInIncreasingOrder.cs) | Medium | `Array`, :star:`Queue` | O(n) | O(n) |
| 985 | :star: [Sum of Even Numbers After Queries](https://leetcode.com/problems/sum-of-even-numbers-after-queries/) | [C#](./CSharp/leetcodesln/SumOfEvenNumbersAfterQueries.cs) | Easy | `Array`, `Prefix Caching` | O(n) | O(n) |
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](./CSharp/leetcodesln/FindCommonCharacters.cs) | Easy | `Array`, `HashTable` | O(26*26) | O(n) |
| 1222| :star:[Queens That Can Attack the King](https://leetcode.com/problems/queens-that-can-attack-the-king/) | [C#](./CSharp/leetcodesln/QueensThatCanAttackTheKing.cs) | Medium | `Array` | O(1) | O(64) |

### Stack
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 844 | [Backspace String Compare](https://leetcode.com/problems/backspace-string-compare/) | [C#](./CSharp/leetcodesln/BackspaceStringCompare.cs) | Easy | `Stack`, :star:`Two Pointers` | O(n) | O(1) | 

### HashTable & HashSet
Hashtable has O(1) read/write, hashtable are often used to save preprocessed results or find matching elements.

| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](./CSharp/leetcodesln/TwoSum.cs) [Go](./Go/questions/TwoSum.go) | Easy | `Two Pointers`, `Hashtable` | O(n), O(n) | O(1), O(n) |
| 36 | :star:[Valid Suduku](https://leetcode.com/problems/valid-sudoku/) | [C#](./CSharp/leetcodesln/ValidSudoku.cs) | Medium | `Hashtable` | O(81) | O(81*3) |
| 76 | [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) | [C#](./CSharp/leetcodesln/MinimumWindowSubstring.cs) | Hard | `Sliding Window`, `HashTable` | O(n) | O(n) | 
| 299 | [Bulls and Cows](https://leetcode.com/problems/bulls-and-cows/) | [C#](./CSharp/leetcodesln/BullsAndCows.cs) | Easy | `HashTable` | O(n) | O(n) |
| 349 | [Intersection of Two Arrays](https://leetcode.com/problems/intersection-of-two-arrays/) | [C#](./CSharp/leetcodesln/IntersectionOfTwoArrays.cs) [Go](./Go/tests/IntersectionOfTwoArrays_test.go) | Easy | `Two Pointers`, `HashSet` | O(n) | O(n) |
| 438 | :star: [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](./CSharp/leetcodesln/FindAllAnagramsInAString.cs) | Medium | `Two Pointers`, `Sliding Window`, `HashTable` | O(n) | O(1) |
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](./CSharp/leetcodesln/PermutationInString.cs) | Medium | `HashTable`, `Sliding Window`, `Two Pointers` | O(n) | O(n) | 
| 961 | [N-Repeated Element in Size 2N Array](https://leetcode.com/problems/n-repeated-element-in-size-2n-array/) | [C#](./CSharp/leetcodesln/N-RepeatedElementInSize2NArray.cs) | Easy | `Hashtable`, `Array` | O(n) | O(n) |
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](./CSharp/leetcodesln/FindCommonCharacters.cs) | Easy | `Array`, `HashTable` | O(26*26) | O(n) |

### Dynamic Programming
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 1143| :star::star:[Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/) | [C#](./CSharp/leetcodesln/LongestCommonSubsequence.cs) | Medium | `DP` | O(n^2) | O(n^2) |


### Backtracking
| # | Question | Solution | Difficulty | Tag | Time Complexity | Space Complexity | 
|---|----|--------|--------|----|-----|------|
| 39 | :star: [Combination Sum](https://leetcode.com/problems/combination-sum/) | [C#](./CSharp/leetcodesln/CombinationSum.cs) | Medium | `Backtracking` | O(2^n) | O(n) |