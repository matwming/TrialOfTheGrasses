using System.Collections.Generic;

namespace leetcodesln
{
    public class FindWordsThatCanBeFormedByCharacters
    {
        public int CountCharacters(string[] words, string chars)
        {
            int ans = 0;
            var dict = new Dictionary<char, int>();

            foreach (var chr in chars)
            {
                if (dict.ContainsKey(chr)) { dict[chr]++; }
                else { dict.Add(chr, 1); }
            }

            foreach (var word in words)
            {
                bool canForm = true;
                var d = new Dictionary<char, int>();
                foreach (var chr in word)
                {
                    if (d.ContainsKey(chr)) { d[chr]++; }
                    else { d.Add(chr, 1); }
                }

                foreach (var dd in d)
                {
                    if (!dict.ContainsKey(dd.Key) || dict[dd.Key] < dd.Value)
                    {
                        canForm = false;
                        break;
                    }
                }
                if (canForm) ans += word.Length;
            }
            return ans;
        }
    }
}
