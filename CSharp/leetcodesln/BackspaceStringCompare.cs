using System.Collections.Generic;

namespace leetcodesln
{
    public class BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();

            for (int s = 0, t = 0; s < S.Length || t < T.Length;)
            {
                if (s < S.Length)
                {
                    if (S[s] == '#')
                    {
                        if (stackS.Count != 0)
                        {
                            stackS.Pop();
                        }
                        s++;
                    }
                    else { stackS.Push(S[s]); s++; }
                }
                if (t < T.Length)
                {
                    if (T[t] == '#')
                    {
                        if (stackT.Count != 0)
                        {
                            stackT.Pop();
                        }
                        t++;
                    }
                    else { stackT.Push(T[t]); t++; }
                }
            }

            return DeepCompare(stackS, stackT);
        }

        private bool DeepCompare(Stack<char> stackS, Stack<char> stackT)
        {
            if (stackS.Count != stackT.Count) return false;
            else
            {
                for (int i = 0; i < stackT.Count; i++)
                {
                    if (stackS.Pop() != stackT.Pop()) return false;
                }
            }
            return true;
        }


        // O(n) time complexity, two pointers start from backwards
        public bool BackspaceCompareTwoPointers(string s, string t)
        {
            int sback = s.Length - 1, tback = t.Length - 1, scount = 0, tcount = 0;

            while (sback >= 0 || tback >= 0)
            {
                while (sback >= 0 && (s[sback] == '#' || scount > 0))
                {
                    if (s[sback--] == '#') scount++;
                    else scount--;
                }
                while (tback >= 0 && (t[tback] == '#' || tcount > 0))
                {
                    if (t[tback--] == '#') tcount++;
                    else tcount--;
                }
                if (sback < 0 || tback < 0) return sback == tback;
                if (s[sback--] != t[tback--]) return false;
            }
            return true;
        }
    }
}
