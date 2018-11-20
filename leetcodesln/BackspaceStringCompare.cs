using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();

            for (int s = 0, t = 0; s < S.Length || t< T.Length; )
            {
                if(s< S.Length)
                {
                    if (S[s] == '#')
                    {
                        if(stackS.Count!=0)
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
    }
}
