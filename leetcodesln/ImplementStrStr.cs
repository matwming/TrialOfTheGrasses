using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) throw new NullReferenceException();

            var h = haystack.Length;
            var n = needle.Length;

            if(h < n) return -1;
            if(h == n && haystack == needle) return 0;

            int[] kmpArray = new int[n];
            List<int> matchedIndex = new List<int>();

            FormPrefixTable(needle, ref kmpArray);

            int i = 0, j = 0;

            while (i < h)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }

                //match found at i-j
                if (j == n)
                {
                    matchedIndex.Add(i-j);
                    j = kmpArray[j-1];
                }
                else if (i < h && haystack[i] != needle[j])
                {
                    if(j != 0)
                    {
                        j = kmpArray[j-1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return -1;
        }

        private void FormPrefixTable(string pattern, ref int[] kmpArray)
        {
            int pLen = pattern.Length;
            int len = 0;
            kmpArray[0] = 0;
            int i = 1;

            while (i < pLen)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    kmpArray[i] = len;
                    i++;
                }
                else
                {
                    if (len == 0)
                    {
                        kmpArray[i] = 0;
                        i++;
                    }
                    else
                    {
                        len = kmpArray[len -1];
                    }
                }
            }
        }
    }   
}