using System.Text;

namespace leetcodesln
{
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            var buffer = new StringBuilder[numRows];

            for (int i = 0; i < numRows; i++)
            {
                buffer[i] = new StringBuilder();
            }

            int j = 0;
            while (j < s.Length)
            {
                for (int idx = 0; idx < numRows && j < s.Length; ++idx)
                {
                    buffer[idx].Append(s[j++]);
                }
                for (int idx = numRows - 2; idx >= 1 && j < s.Length; --idx)
                {
                    buffer[idx].Append(s[j++]);
                }
            }

            for (int i = 1; i < buffer.Length; i++)
            {
                buffer[0].Append(buffer[i]);
            }

            return buffer[0].ToString();
        }

        public string Convert2(string s, int numRows)
        {
            var rows = new StringBuilder[numRows];

            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }

            bool down = false;
            int current = 0;
            for (int i = 0; i < s.Length; i++)
            {
                rows[current].Append(s[i]);
                if (current == 0 || current == numRows - 1) down = !down;
                current += down ? 1 : -1;
            }

            for (int i = 1; i < rows.Length; i++)
            {
                rows[0].Append(rows[i]);
            }
            return rows[0].ToString();
        }
    }
}
