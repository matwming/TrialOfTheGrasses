using System.Collections.Generic;

namespace leetcodesln
{
    public class LongestWordInDictionary
    {
        public string LongestWord(string[] words)
        {
            if (words.Length == 0) return string.Empty;
            var dict = new Dictionary<int, List<string>>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word.Length))
                {
                    dict[word.Length].Add(word);
                }
                else
                {
                    dict.Add(word.Length, new List<string> { word });
                }
            }
            var list = new List<string>();
            FindWords( ref list, dict[1], 2, dict);
            
            if (list.Count == 0) return string.Empty;
            var max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Length > max.Length)
                {
                    max = list[i];
                    continue;
                }
                if (list[i].Length == max.Length )
                {
                    for (int j = 0; j < max.Length; j++)
                    {
                        if(list[i][j] > max[j])
                        {
                            break;
                        }
                        else if(list[i][j]< max[j])
                        {
                            max = list[i];
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            return max;
        }

        private void FindWords(ref List<string> finalList, List<string> list, int layer, Dictionary<int, List<string>> dict)
        {
           if(!dict.ContainsKey(layer))
            {
                finalList.AddRange(list);
                return;
            }
            
            foreach (var current in list)
            {
                var templist = new List<string>();
                foreach (var word in dict[layer])
                {
                    if (IsPrefix(current, word)) templist.Add(word);
                }
                if (templist.Count == 0) FindWords(ref finalList, list, int.MaxValue, dict);

                else FindWords(ref finalList, templist, layer + 1, dict);
            }
        }

        private bool IsPrefix(string current, string wordFromList)
        {
            for (int i = 0; i < current.Length; i++)
            {
                if (current[i] != wordFromList[i]) return false;
            }
            return true;
        }
    }
}