namespace leetcodesln
{
    public class IsomorphicStrings
    {
        //public bool IsIsomorphic(string s, string t)
        //{
        //    return s == t ? true : s.Length == t.Length ? IsIsomorphicAux(s, t): false;
        //}

        //private bool IsIsomorphicAux(string s, string t)
        //{
        //    var dicts = new Dictionary<char, int>();
        //    var dictt = new Dictionary<char, int>();
        //    var ds = 0;
        //    var dt = 0;
        //    var nstrs = string.Empty;
        //    var nstrt = string.Empty;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if(!dicts.ContainsKey(s[i])) dicts.Add(s[i],ds++);
        //        if(!dictt.ContainsKey(t[i])) dictt.Add(t[i], dt++);
        //    }
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        nstrs += dicts[s[i]];
        //        nstrt += dictt[t[i]];
        //    }
        //    return nstrs == nstrt;
        //}

        //a good solution
        public bool IsIsomorphic(string s, string t)
        {
            return s == t ? true : s.Length == t.Length ? IsIsomorphicAux(s, t) : false;
        }

        private bool IsIsomorphicAux(string s, string t)
        {
            int[] sm = new int[128];
            int[] tm = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                if (sm[s[i]] != tm[t[i]]) return false;
                sm[s[i]] = i + 1;  // use i+1 instead of i as arrays are initialized as 0, to avoid putting 0 into the array for avoiding this ambiguity
                tm[t[i]] = i + 1;
            }
            return true;
        }
    }
}