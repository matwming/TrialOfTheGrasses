using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class LongestPalindrome
    {
        public int FindLongestPalindrome(string s)
        {
            int longestPalindrome = 0;
            var dictionary = ToDictionary(s);
            foreach (var item in dictionary)
            {
                if (item.Value % 2==0)
                {
                    longestPalindrome += item.Value;
                }
            }
            if (longestPalindrome < s.Length)
            {
                longestPalindrome++;
            }
            return longestPalindrome;
        }

        private ConcurrentDictionary<char,int> ToDictionary(string s)
        {
            ConcurrentDictionary<char, int> result = new ConcurrentDictionary<char, int>();
            foreach (var character in s.ToCharArray())
            {
                result.AddOrUpdate(character, 1, (key, oldValue) => oldValue + 1);
            }
            return result;
        }
    }
}
