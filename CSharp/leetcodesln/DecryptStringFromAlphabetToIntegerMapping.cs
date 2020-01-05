using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            var map = new Dictionary<string, char>
            {
                {"1" , 'a'},
                {"2" , 'b'},
                {"3" , 'c'},
                {"4" , 'd'},
                {"5" , 'e'},
                {"6" , 'f'},
                {"7" , 'g'},
                {"8" , 'h'},
                {"9" , 'i'},
                {"10#" , 'j'},
                {"11#" , 'k'},
                {"12#" , 'l'},
                {"13#" , 'm'},
                {"14#" , 'n'},
                {"15#" , 'o'},
                {"16#" , 'p'},
                {"17#" , 'q'},
                {"18#" , 'r'},
                {"19#" , 's'},
                {"20#" , 't'},
                {"21#" , 'u'},
                {"22#" , 'v'},
                {"23#" , 'w'},
                {"24#" , 'x'},
                {"25#" , 'y'},
                {"26#" , 'z'},

            };

            var sb = new StringBuilder();
            var len = s.Length - 1;
            while (len >= 0)
            {
                if (s[len] == '#')
                {
                    len -= 2;
                    sb.Append(map[s.Substring(len, 3)]);
                    len--;
                }
                else
                {
                    var idx = s.Substring(len--, 1);
                    sb.Append(map[idx]);

                }
            }
            var chararr = sb.ToString().ToCharArray();
            Array.Reverse(chararr);
            return new string(chararr);
        }
    }
}
