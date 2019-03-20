namespace leetcodesln
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWordSln(string s)
        {
            s = s.TrimEnd();
            string[] strs = s.Split(' ');

            return strs[strs.Length - 1].Length;
        }
    }
}