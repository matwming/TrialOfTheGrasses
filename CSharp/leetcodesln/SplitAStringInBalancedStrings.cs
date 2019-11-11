using System.Collections.Generic;

namespace leetcodesln
{
    public class SplitAStringInBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            if (s.Length == 0) return 0;
            int ans = 0;
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; ++i)
            {
                if (stack.Count != 0 && stack.Peek() != s[i]) stack.Pop();
                else stack.Push(s[i]);
                if (stack.Count == 0) ans++;
            }
            return ans;
        }
    }
}
