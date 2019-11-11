namespace leetcodesln
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;

            while (l < r)
            {
                while (l < r && !char.IsLetterOrDigit(s[l])) ++l;
                while (r > l && !char.IsLetterOrDigit(s[r])) --r;
                if (char.ToLower(s[l++]) != char.ToLower(s[r--])) return false;
            }
            return true;
        }
    }
}
