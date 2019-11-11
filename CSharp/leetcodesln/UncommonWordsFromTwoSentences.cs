using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class UncommonWordsFromTwoSentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            string[] sumlist = (A + " " + B).Split(' ');
            var dict = new Dictionary<string, int>();
            foreach (var str in sumlist)
            {
                if (dict.ContainsKey(str))
                {
                    dict[str]++;
                }
                else
                {
                    dict.Add(str, 1);
                }
            }

            var reslist = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value<=1)
                {
                    reslist.Add(item.Key);
                }
            }
            return reslist.ToArray();
        } 
    }
}