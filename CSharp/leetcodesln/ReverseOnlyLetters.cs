using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ReverseOnlyLetters
    {
        public string ReverseOnlyLettersSln(string S)
        {
            var res_arr = new char[S.Length];
            int tail = S.Length-1;
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsLetter(S[i]))
                {
                    tail = GetLetterPositionIndex(S, tail);
                    res_arr[tail] = S[i];
                    tail--;
                }
                else
                {
                    res_arr[i] = S[i];
                }
            }
            return new string(res_arr);
        }

        private int GetLetterPositionIndex(string S, int index)
        {
            if (char.IsLetter(S[index]))
            {
                return index;
            }
            return GetLetterPositionIndex(S, --index);
        }
    }
}
