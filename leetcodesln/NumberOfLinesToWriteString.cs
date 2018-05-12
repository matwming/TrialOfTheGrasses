namespace leetcodesln
{
    public class NumberOfLinesToWriteString
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            int allWidths = 0;

            for (int i = 0; i < S.Length -1; i++)
            {
                allWidths += widths[S[i] - 'a'];
            }
            int carry = 0;
            int position;
            int lines = allWidths / 100;
            if ((100 - (allWidths % 100)) >= (widths[S[S.Length -1] - 'a']))
            {
                position = allWidths % 100 + (widths[S[S.Length -1] - 'a']);
                carry++;
            }
            else
            {
                position = widths[S[S.Length -1] - 'a'];
                carry += 2;
            }
            return new int[] {lines + carry, position};
        }
    }
    
}