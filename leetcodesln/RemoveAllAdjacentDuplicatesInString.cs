using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string S)
        {
            var before = S;
            var after = RemoveProcess(S);
            while(before != after)
            {
                before = after;
                after = RemoveProcess(after);
                
            }
            return after;
        }

        private string RemoveProcess(string s)
        {
            for (int i = 0; i < s.Length-1; i++)
            {
                if(s[i] == s[i+1])
                {
                    return s.Remove(i, 2);
                }
            }
            return s;
        }
    }
}
