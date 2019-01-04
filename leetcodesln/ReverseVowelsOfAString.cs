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
    }
}
