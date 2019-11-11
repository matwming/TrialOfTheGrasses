using System;
using System.Collections.Generic;

namespace leetcodesln
{

    //  题目可以让在 偶数位置的 chars 互换， 也可以让 在 奇数位置的 chars 互换。

    //所以为了 return 正确的 group 数量，需要把 那些重复的 给排除掉。

    //可以把在 偶数位置的 chars 都拿出来 组成一个 string a， 同样的把 在奇数位置上的 chars 都拿出来组成一个 string b，分别把a 和 b 排序一下，再把两个a 和 b组合并且存入 HashSet。

    //最后只要返回 HashSet 的 size 就可以了

    public class GroupOfSpecial_EquivalentStrings
    {
        public int NumSpecialEquivGroups(string[] A)
        {
            var set = new HashSet<string>();

            foreach (var str in A)
            {
                var evenCharsStr = string.Empty;
                var oddCharsStr = string.Empty;
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0) evenCharsStr += str[i];
                    else oddCharsStr += str[i];
                }
                set.Add(SortString(evenCharsStr) + SortString(oddCharsStr));
            }

            return set.Count;
        }

        private string SortString(string s)
        {
            char[] chrarr = s.ToCharArray();

            Array.Sort(chrarr);

            return new string(chrarr);
        }
    }
}
