using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach (var chr in s)
            {
                var count = dict.ContainsKey(chr) ? dict[chr] + 1 : 1;
                dict[chr] = count;
            }

            foreach (var chr in t)
            {
                if (dict.ContainsKey(chr))
                {
                    if (dict[chr] == 1)
                    {
                        dict.Remove(chr);
                    }
                    else dict[chr] -= 1;
                }
                else return false;
            }
            return dict.Count() == 0;
        }
    }
}