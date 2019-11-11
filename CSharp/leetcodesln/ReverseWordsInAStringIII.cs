using System.Text;

namespace leetcodesln
{
    public class ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            var sb = new StringBuilder();
            var words = s.Split(' ');
            foreach (var word in words)
            {
                sb.Append(ReverseWord(word));
                sb.Append(" ");
            }
            sb.Length--;
            return sb.ToString();
        }

        private string ReverseWord(string word)
        {
            var strarr = new char[word.Length];
            var left = 0;
            var right = word.Length - 1;
            while (left <= right)
            {
                strarr[left] = word[right];
                strarr[right] = word[left];
                left++;
                right--;
            }
            return new string(strarr);
        }
    }
}
