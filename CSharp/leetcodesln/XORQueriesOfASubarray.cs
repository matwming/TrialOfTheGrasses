namespace leetcodesln
{
    public class XORQueriesOfASubarray
    {
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            var prefixXOR = new int[arr.Length + 1];

            for (int i = 1; i < prefixXOR.Length; i++)
            {
                prefixXOR[i] = prefixXOR[i - 1] ^ arr[i - 1];
            }

            var ans = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                var l = queries[i][0];
                var r = queries[i][1];

                ans[i] = prefixXOR[r + 1] ^ prefixXOR[l];
            }
            return ans;

        }
    }
}
