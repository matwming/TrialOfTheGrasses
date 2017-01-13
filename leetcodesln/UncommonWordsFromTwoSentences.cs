using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class UncommonWordsFromTwoSentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var list_a = A.Split(' ').ToList();
            foreach (var str in list_a)
            {
                list_a = RemoveDuplicates(list_a, str);
            }

            var list_b = B.Split(' ').ToList();

            foreach (var str in list_b)
            {
                list_b = RemoveDuplicates(list_b, str);
            }

            foreach (var str in list_a)
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

           
            return list_b.ToArray();
        }

        private List<string> RemoveDuplicates(IList<string> list, string item)
        {
            var temp = list.ToList();
            temp.Remove(item);
            if (temp.Contains(item))
            {
                temp.Remove(item);
                list = temp;
                RemoveDuplicates(list, item);
            }
            return (List<string>)list;
        }
    }
}