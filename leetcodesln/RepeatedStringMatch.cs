using System.Text;

namespace leetcodesln
{
    public class RepeatedStringMatch
    {
        public int RepeatedStringMatchSln(string A, string B)
        {
            if (A.Length == 0) return -1;

            var sb = new StringBuilder(A);
            var repected = 1;
            for (; sb.Length < B.Length; ++repected)
            {
                sb.Append(A);
            }
            if (sb.ToString().IndexOf(B) >= 0) return repected;
            if (sb.Append(A).ToString().IndexOf(B) >= 0) return ++repected;
            return -1;
        }
    }
}