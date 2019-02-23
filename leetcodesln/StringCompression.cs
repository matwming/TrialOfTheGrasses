using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class StringCompression
    {
        public int Compress(char[] chars)
        {
            var ptr = 0;
            var explorer = 0;

            while(explorer< chars.Length)
            {
                var count = 0;
                var current = chars[explorer];
                while(explorer < chars.Length && current == chars[explorer])
                {
                    count++;
                    explorer++;
                }

                chars[ptr++] = current;

                if(count>1)
                {
                    foreach (var num in count.ToString().ToCharArray())
                    {
                        chars[ptr++] = num;
                    }
                }
            }
            return ptr;
        }
    }
}