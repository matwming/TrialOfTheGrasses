using System.Collections.Generic;

namespace leetcodesln
{
    public class MinimumAddToMakeParenthesesValid
    {
        public int MinAddToMakeValid(string S)
        {
            var ans = 0;
            var leftSet = new HashSet<char> { '(', '[', '{' };
            var stack = new Stack<char>();
            foreach (var chr in S)
            {
                if (leftSet.Contains(chr))
                {
                    switch (chr)
                    {
                        case '(':
                            stack.Push(')');
                            break;
                        case '[':
                            stack.Push(']');
                            break;
                        case '{':
                            stack.Push('}');
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (stack.Count != 0 && chr == stack.Peek())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        ++ans;
                    }
                }
            }
            return stack.Count == 0 ? ans : ans + stack.Count;
        }
    }
}
