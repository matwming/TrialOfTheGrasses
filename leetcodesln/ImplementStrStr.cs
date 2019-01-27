using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if(string.IsNullOrEmpty(needle)) return 0;

            if(string.IsNullOrEmpty(haystack)) return -1;

            var hLen = haystack.Length;
            var nlen = needle.Length;

            if(nlen > hLen) return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if(haystack[i] == needle[0])
                {
                    if(ContainSubstring(haystack, needle, i)) return i;
                }
            }
            return -1;
        }

        private bool ContainSubstring(string haystack, string needle, int i)
        {
            for (int n = 0; n < needle.Length; n++, i++)
            {
                if(i < haystack.Length)
                {
                    if(haystack[i] == needle[n]) continue;
                    else return false;
                }
                else return false;
            }
            return true;
        }
    }
}