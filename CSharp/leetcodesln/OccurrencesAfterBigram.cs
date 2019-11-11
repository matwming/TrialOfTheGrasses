using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class OccurrencesAfterBigram
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var ans = new List<string>();
            var words = text.Split(' ');

            var buffer = new StringBuilder();

            for (int i = 0; i < words.Length - 2; i++)
            {
                buffer.Append(words[i]).Append(" ").Append(words[i + 1]);
                if (buffer.ToString() == $"{first} {second}") ans.Add(words[i + 2]);
                buffer = new StringBuilder();
            }
            return ans.ToArray();
        }
    }
}
