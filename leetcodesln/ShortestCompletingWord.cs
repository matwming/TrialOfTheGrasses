using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class ShortestCompletingWord
    {
        public string ShortestCompletingWordSln(string licensePlate, string[] words)
        {
            var lp = new List<char>();
            foreach (var chr in licensePlate)
            {
                if (char.IsLetter(chr))
                {
                    lp.Add(char.ToLower(chr));
                }
            }
            string result = string.Empty;
            var shortest = int.MaxValue;

            foreach (var word in words)
            {
                if (IsCompletingWord(lp, word.ToLower().ToList()))
                {
                    if (word.Length< shortest)
                    {
                        result = word;
                        shortest = word.Length;
                    }
                }
                

            }
            return result;
        }

        private bool IsCompletingWord(List<char> licenseplate, List<char> word)
        {
            foreach (var chr in licenseplate)
            {
                if (word.Contains(chr))
                {
                    word.Remove(chr);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}