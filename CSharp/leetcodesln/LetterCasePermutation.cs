using System;
using System.Collections.Generic;
using System.Text;

//https://blog.csdn.net/u011437229/article/details/53188837

namespace leetcodesln
{
    public class LetterCasePermutation
    {
        public IList<string> LetterCasePermutationSln(string S)
        {
            List<string> resList = new List<string>();
            Dfs(S, new StringBuilder(), 0,resList);
            return resList;
        }

        private void Dfs(string s, StringBuilder sb, int index, List<string> resList)
        {
            if (index == s.Length)
            {
                resList.Add(sb.ToString());
                return;
            }
            char c = s[index];
            if (Char.IsNumber(c))
            {
                sb.Append(c);
                Dfs(s, sb, index + 1, resList);
                sb.Length--;
            }
            else
            {
                sb.Append(Char.ToLower(c));
                Dfs(s, sb, index + 1, resList);
                sb.Length--;
                sb.Append(Char.ToUpper(c));
                Dfs(s, sb, index + 1, resList);
                sb.Length--;
            }
        }
    }
}

/**
 * DFS算法思想： 一直往深处走，知道找到解或者走不下去为止
 * dfs(depth,....) depth代表目前dfs的深度
 * {
 *      if(solution found || cannot go further)
 *      {
 *          //do stuff
 *          return;
 *      }
 *      
 *      枚举下一个可能情况: dfs(depth +1, ...)
 * }
 * */
