using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class UncommonWordsFromTwoSentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var arr_a = A.Split(' ');
            var list_b = B.Split(' ').ToList();
            foreach (var str in arr_a)
            {
                if (list_b.Contains(str))
                {
                    list_b.Remove(str);
                }
                else
                {
                    list_b.Add(str);
                }
            }
            
            var dictionary = new Dictionary<string, int>();
            foreach(var str in list_b)
            {
                
            }
        }
    }
}