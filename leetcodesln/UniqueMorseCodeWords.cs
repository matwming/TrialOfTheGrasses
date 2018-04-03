using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCodeTable = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                foreach (var character in words[i])
                {
                    sb.Append(morseCodeTable[character - 97]);
                }
                words[i] = sb.ToString();
                sb = new StringBuilder();
            }
            HashSet<string> set = new HashSet<string>();
            foreach (var word in words)
            {
                set.Add(word);
            }
            return set.Count;
        }
    }
}
