namespace leetcodesln
{
    public class ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (s[l] != s[r]) { return Aux(s, l + 1, r) || Aux(s, l, r - 1); }
                l++;
                r--;
            }
            return true;
        }

        bool Aux(string s, int l, int r)
        {
            while (l < r)
            {
                if (s[l] != s[r]) return false;
                l++;
                r--;
            }
            return true;
        }
    }
}
