// using System.Collections.Generic;

// namespace leetcodesln
// {
//     public class LongestWordInDictionary
//     {
//         public string LongestWord(string[] words)
//         {
//             var dict = new Dictionary<int, List<string>>();
//             foreach (var word in words)
//             {
//                 if(dict.ContainsKey(word.Length)) 
//                 {
//                     dict[word.Length].Add(word);
//                 }
//                 else
//                 {
//                     dict.Add(word.Length, new List<string>{word});
//                 }
//             }
//             if(dict.TryGetValue(1, out var startchars))
//             {
//                 foreach (var chr in startchars)
//                 {
                    
//                 }
//             }
//             else
//             {
//                 return string.Empty;
//             }
//         }

//         private List<string> FindWords(string currentWord, int layer, Dictionary<int, List<string>> dict, List<string> list)
//         {
//             if(!dict.ContainsKey(layer))
//             {
//                 return list;
//             }
//             else
//             {
//                 foreach (var chr in dict[layer])
//                 {
//                     if(IsPrefix(currentWord, chr))
//                     {
//                         list.Clear();
//                         list.Add(chr);
//                         if(dict.ContainsKey(layer+1))
//                         {
//                             list = FindWords(chr, layer+1, dict, list);
//                         }
//                         else
//                         {
//                             return list;
//                         }
//                     }
//                 }
//             }
//         }

//         private bool IsPrefix(string current, string wordFromList)
//         {
//             for (int i = 0; i < current.Length; i++)
//             {
//                 if(current[i]!=wordFromList[i]) return false;
//             }
//             return true;
//         }
//     }
// }