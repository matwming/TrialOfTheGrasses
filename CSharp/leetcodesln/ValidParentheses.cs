using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            var open = new char[] { '(', '[', '{' };
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (open.Contains(s[i])) stack.Push(s[i]);
                else
                {
                    var current = default(char);
                    if (stack.Count == 0) return false;
                    if (stack.Peek() == '(') current = ')';
                    if (stack.Peek() == '[') current = ']';
                    if (stack.Peek() == '{') current = '}';

                    if (current != s[i]) return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}