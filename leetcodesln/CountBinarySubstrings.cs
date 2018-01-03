namespace leetcodesln
{
    public class CountBinarySubstrings
    {
        public int CountBinarySubstringsSln(string s)
        {
            int previous = 0;
            int current = 1;
            int count = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i]==s[i-1])
                {
                    current++;
                }
                else
                {
                    previous = current;
                    current = 1;
                }
                if (previous>=current)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
