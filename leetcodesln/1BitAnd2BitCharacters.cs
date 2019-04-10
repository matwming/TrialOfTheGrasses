namespace leetcodesln
{
    public class _1BitAnd2BitCharacters
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int i = 0;

            while (i < bits.Length - 2)
            {
                if (bits[i] == 1) i += 2;
                else ++i;
            }
            return bits[i] == 0;
        }
    }
}
