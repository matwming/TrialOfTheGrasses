using System.Collections.Generic;

namespace leetcodesln
{
    public class LongestWordInDictionaryThroughDeleting
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            string ans = string.Empty;
            foreach (var word in d)
            {
                if (word.Length <= s.Length)
                {
                    if (CanFormByDelete(s, word))
                    {
                        if (ans.Length < word.Length)
                        {
                            ans = word;
                        }
                        else if (ans.Length == word.Length)
                        {
                            ans = ans[0] > word[0] ? word : ans;
                        }
                    }
                }
            }
            return ans;
        }

        private bool CanFormByDelete(string s, string word)
        {
            var ls = 0;
            var ws = 0;
            while (ls < s.Length && ws < word.Length)
            {
                if (word[ws] == s[ls])
                {
                    ls++;
                    ws++;
                }
                else
                {
                    ls++;
                }
            }
            return ws == word.Length;
        }
    }
}
