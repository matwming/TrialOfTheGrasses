using System;

namespace leetcodesln
{
    public class LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            int l = 0, fast = 0, maxCount = 0, maxLength = 0;
            var cnt = new int[26];
            for (; fast < s.Length; ++fast)
            {
                maxCount = Math.Max(maxCount, ++cnt[s[fast] - 'A']);
                while (fast - l + 1 - maxCount > k)
                {
                    cnt[s[l++] - 'A']--;
                }
                maxLength = Math.Max(maxLength, fast - l + 1);
            }
            return maxLength;
        }
    }
}
