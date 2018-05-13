namespace leetcodesln
{
    public class NumberOfLinesToWriteString
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            const int LINE = 100;
            int line = 1;
            int position = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (LINE - position < widths[S[i]-'a'])
                {
                    line ++;
                    position = widths[S[i] - 'a'];
                }
                else
                {
                    position += widths[S[i]-'a'];
                }
            }
            return new int[] {line, position};
        }
    }
    
}