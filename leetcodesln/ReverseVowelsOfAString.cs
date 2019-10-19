using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class ReverseVowelsOfAString
    {
        public string ReverseVowels(string s)
        {
            if (s.Length <= 1) return s;

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var str = s.ToCharArray();

            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (vowels.Contains(s[left]) && vowels.Contains(s[right]))
                {
                    var temp = s[left];
                    str[left] = s[right];
                    str[right] = temp;
                    left++;
                    right--;
                }
                if (!vowels.Contains(s[left])) left++;
                if (!vowels.Contains(s[right])) right--;
            }
            return new string(str);
        }

        public string ReverseVowels2(string s)
        {
            var ss = s.ToCharArray();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                while (!vowels.Contains(ss[l]) && l < r) ++l;
                while (!vowels.Contains(ss[r]) && r > l) --r;
                var temp = s[l];
                ss[l++] = ss[r];
                ss[r--] = temp;
            }
            return new string(ss);
        }
    }
}
