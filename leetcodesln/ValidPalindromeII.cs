namespace leetcodesln
{
    public class ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            if (s.Length <= 1) return true;

            return IsPalindromeLeft(s, 0, s.Length-1) || IsPalindromeRight(s, 0, s.Length-1);
        }

        private bool IsPalindromeLeft(string s, int left, int right)
        {
            if (s.Length <= 1) return true;

            var chance = 1;

            while (left <= right)
            {
                if (IsSameChar(s[left], s[right]) && chance >= 0)
                {
                    left++;
                    right--;
                }
                else if (IsSameChar(s[left + 1], s[right]) && chance > 0)
                {
                    left++;
                    chance--;
                    continue;
                }
                else return false;
            }
            return true;
        }

        private bool IsPalindromeRight(string s, int left, int right)
        {
            if (s.Length <= 1) return true;

            var chance = 1;

            while (left <= right)
            {
                if (IsSameChar(s[left], s[right]) && chance >= 0)
                {
                    left++;
                    right--;
                }
                else if (IsSameChar(s[left], s[right-1]) && chance > 0)
                {
                    right--;
                    chance--;
                    continue;
                }
                else return false;
            }
            return true;
        }

        private bool IsSameChar(char a, char b) => a == b;
    }
}
