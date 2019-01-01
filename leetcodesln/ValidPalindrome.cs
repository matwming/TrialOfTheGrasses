namespace leetcodesln
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            for (int front = 0, end = s.Length - 1; front < end; front++, end--)
            {
                while (!char.IsLetterOrDigit(s[front]) && front < s.Length - 1)
                {
                    front++;
                }
                while (!char.IsLetterOrDigit(s[end]) && end > 0)
                {
                    end--;
                }

                if (front <= end)
                {
                    if (char.ToLower(s[front]) == char.ToLower(s[end]))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
