using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ScoreOfParentheses
    {
        public int ScoreOfParenthesesSln(string S)
        {
            var stack = new Stack<int>();
            int cur = 0;
            foreach (var chr in S)
            {
                if (chr == '(')
                {
                    stack.Push(cur);
                    cur = 0;
                }
                else
                {
                    cur = stack.Pop() + Math.Max(cur * 2, 1);
                }
            }
            return cur;
        }
    }
}