using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;  // for some reason, this statement is needed in leetcode in order to run successfully

namespace leetcodesln
{
    public class MostCommonWord
    {
        public string MostCommonWordSln(string paragraph, string[] banned)
        {
            var fixinput = Regex.Replace(paragraph, "[,.?!;\"\']", " ");
            var tempo = new Regex("[ ]{2,}", RegexOptions.None).Replace(fixinput, " ");
            var wordDict = new Dictionary<string, int>();
            string[] words = tempo.Split(" ");
            string mostFrequent = string.Empty;
            var maxOccur = 0;

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
                if (wordDict.ContainsKey(words[i])) wordDict[words[i]]++;
                else
                {
                    wordDict.Add(words[i], 1);
                }
                if (wordDict[words[i]] > maxOccur && !banned.Contains(words[i]))
                {
                    mostFrequent = words[i];
                    maxOccur = wordDict[words[i]];
                }
            }
            return mostFrequent;
        }
    }
}
