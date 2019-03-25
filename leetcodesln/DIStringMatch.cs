namespace leetcodesln
{
    public class DIStringMatch
    {
        public int[] DiStringMatch(string S)
        {
            if (S.Length == 0) return null;

            var result = new int[S.Length + 1];

            var currentMax = S.Length;
            var currentMin = 0;

            for (int i = 0; i < S.Length; i++)
            {
                result[i] = S[i] == 'I' ? currentMin++ : currentMax--;
            }

            result[S.Length] = currentMax;
            return result;
        }
    }
}
