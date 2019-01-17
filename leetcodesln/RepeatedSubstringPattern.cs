namespace leetcodesln
{
    public class RepeatedSubstringPattern
    {
        public bool RepeatedSubstringPatternSln(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 0) return false;

            var strlen = s.Length;
            for (int i = 1; i < strlen; i++)
            {
                if (strlen % i == 0)
                {
                    if (IsRepeatedSubstring(s, i)) return true;
                }
            }
            return false;
        }

        private bool IsRepeatedSubstring(string s, int i)
        {
            
            var baseline = s.Substring(0, i);

            for (int j = 0; j < s.Length; j += i)
            {
                if (s.Substring(j, i) != baseline) return false;
            }
            return true;
        }
    }
}
