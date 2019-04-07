using System.Text;

namespace leetcodesln
{
    public class RemoveOutermostParentheses
    {
        public string RemoveOutermostParenthesesSln(string S)
        {
            var sb = new StringBuilder();

            var currentOuterOpenParenthesesPosition = 0;
            var charSum = 0;

            foreach (var chr in S)
            {
                if (chr == '(')
                {
                    charSum += chr;
                    sb.Append(chr);
                }
                else
                {
                    charSum -= chr - 1;
                    sb.Append(chr);
                }
                if (charSum == 0)
                {
                    sb.Remove(currentOuterOpenParenthesesPosition, 1);
                    sb.Remove(sb.Length - 1, 1);
                    currentOuterOpenParenthesesPosition = sb.Length;
                }
            }

            return sb.ToString();
        }
    }
}
