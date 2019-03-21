namespace leetcodesln
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWordSln(string s)
        {
            return s.GetLengthOfLastWord();
        }
    }

    public static class StringExtension
    {
        public static int GetLengthOfLastWord(this string str)
        {
            str = str.TrimEnd();
            string[] strs = str.Split(' ');
            return strs[strs.Length - 1].Length;
        }
    }
}