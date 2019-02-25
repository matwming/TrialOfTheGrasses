using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            return s == t ? true : s.Length == t.Length ? IsIsomorphicAux(s, t): false;
        }

        private bool IsIsomorphicAux(string s, string t)
        {
            var dicts = new Dictionary<char, int>();
            var dictt = new Dictionary<char, int>();
            var ds = 0;
            var dt = 0;
            var nstrs = string.Empty;
            var nstrt = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if(!dicts.ContainsKey(s[i])) dicts.Add(s[i],ds++);
                if(!dictt.ContainsKey(t[i])) dictt.Add(t[i], dt++);
            }
            for (int i = 0; i < s.Length; i++)
            {
                nstrs += dicts[s[i]];
                nstrt += dictt[t[i]];
            }
            return nstrs == nstrt;
        }
    }
}