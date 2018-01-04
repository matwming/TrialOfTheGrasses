namespace leetcodesln
{
    public class _1BitAnd2BitCharacters
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int i = 0;
            while (i<bits.Length-2)
            {
                if (bits[i]==0)
                {
                    i++;
                }
                else
                {
                    i++;
                    i++;
                }
            }
            if (bits[i]==1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
