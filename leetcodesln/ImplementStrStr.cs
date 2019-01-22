using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            var hLen = haystack.Length;
            var nLen = needle.Length;
        
            if(nLen > hLen || (nLen==hLen && haystack!=needle)) return -1;
            if(string.IsNullOrEmpty(needle)) return 0;
            
        
            for(int i=0; i< hLen; i++)
            {
                if(haystack[i]==needle[0])
                {
                    bool notFound = false;
                    for(int j=0, q=i; j < nLen; j++, q++)
                    {
                        if(j> nLen-1) return -1;
                        
                        if(haystack[q]!= needle[j])
                        {
                            notFound = true;
                            break;
                        }
                    }

                    if(!notFound) return i;
                }
            }
            return -1;
        }
    }
}