using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class FindCommonCharacters
    {
        public IList<string> CommonChars(string[] A)
        {
            var frequencyList = new int[26];
            Array.Fill(frequencyList, int.MaxValue);

            foreach (var str in A)
            {
                var countList = BuildStrFrequencyList(str);
                for (int i = 0; i < frequencyList.Length; i++)
                {
                    frequencyList[i] = Math.Min(countList[i], frequencyList[i]);
                }
            }
            return FormResultList(frequencyList);
        }

        private IList<string> FormResultList(int[] frequencyList)
        {
            var resultList = new List<string>();

            for (int i = 0; i < frequencyList.Length; i++)
            {
                for (int j = frequencyList[i]; j > 0; j--)
                {
                    resultList.Add((((char)(i + 'a')).ToString()));
                }
            }
            return resultList;
        }

        private int[] BuildStrFrequencyList(string str)
        {
            int[] count = new int[26];
            foreach (var chr in str)
            {
                count[chr - 'a']++;
            }
            return count;
        }

        public IList<string> CommonCharsFrequencyArray(string[] A)
        {
            var ans = new List<string>();
            var frequencyArray = new int[26];
            Array.Fill(frequencyArray, int.MaxValue);

            foreach (var str in A)
            {
                var count = new int[26];
                for (int i = 0; i < str.Length; i++)
                {
                    ++count[str[i] - 'a'];
                }
                for (int i = 0; i < 26; i++)
                {
                    frequencyArray[i] = Math.Min(count[i], frequencyArray[i]);
                }
            }
            for (char c = 'a'; c <= 'z'; ++c)
            {
                while (frequencyArray[c - 'a']-- > 0) ans.Add(c.ToString());
            }
            return ans;
        }
    }
}
