using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class RemoveAllAdjacentDuplicatesInString
    {
        //public string RemoveDuplicates(string S)
        //{
        //    var before = S;
        //    var after = RemoveProcess(S);
        //    while(before != after)
        //    {
        //        before = after;
        //        after = RemoveProcess(after);
                
        //    }
        //    return after;
        //}

        //private string RemoveProcess(string s)
        //{
        //    for (int i = 0; i < s.Length-1; i++)
        //    {
        //        if(s[i] == s[i+1])
        //        {
        //            return s.Remove(i, 2);
        //        }
        //    }
        //    return s;
        //}

        // best solution using stack
        public string RemoveDuplicates(string S)
        {
            var ans = string.Empty;
            var stack = new Stack<char>();

            foreach (var chr in S)
            {

                if (stack.Count != 0 && stack.Peek() == chr) stack.Pop();
                else stack.Push(chr);
            }

            while (stack.Count != 0) ans = stack.Pop() + ans;

            return ans;
        }
    }
}
