using System.Collections.Generic;

namespace leetcodesln
{
    public class WordPattern
    {
        public bool WordPatternSln(string pattern, string str)
        {
            char[] chrs = pattern.ToCharArray();
            string[] words = str.Trim().Split(" ");

            if (chrs.Length != words.Length) return false;

            var dict = new Dictionary<string, char>();

            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    if (dict[words[i]] != chrs[i]) return false;
                }
                else if (dict.ContainsValue(chrs[i])) return false;
                else dict.Add(words[i], chrs[i]);
            }
            return true;
        }
    }
}
