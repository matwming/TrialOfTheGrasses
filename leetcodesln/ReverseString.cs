using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ReverseString
    {
        public string ReverseStringSln(string s)
        {
            var strarr = new char[s.Length];
            var left = 0;
            var right = s.Length - 1;

            while (left <= right)
            {
                strarr[left] = s[right];
                strarr[right] = s[left];
                left++;
                right--;
            }
            return new string(strarr);
        }
    }
}
