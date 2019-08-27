namespace leetcodesln
{
    public class CompareStringsByFrequencyOfTheSmallestCharacter
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var ans = new int[queries.Length];
            var frequencyArr = new int[words.Length];
            var queriesFrequency = new int[queries.Length];

            for (int i = 0; i < words.Length; i++)
            {
                GetMaxFrequency(ref frequencyArr, words[i], i);
            }
            for (int i = 0; i < queries.Length; i++)
            {
                GetMaxFrequency(ref queriesFrequency, queries[i], i);
            }

            for (int i = 0; i < queriesFrequency.Length; i++)
            {
                GetFrequency(queriesFrequency[i], frequencyArr, ans, i);
            }
            return ans;
        }

        private void GetFrequency(int qf, int[] frequencyArr, int[] ans, int pos)
        {
            var counter = 0;
            for (int i = 0; i < frequencyArr.Length; i++)
            {
                if (qf < frequencyArr[i])
                {
                    counter++;
                }
            }
            ans[pos] = counter;
        }

        private void GetMaxFrequency(ref int[] f, string word, int pos)
        {
            var wordFrequency = new int[26];
            var curMax = 0;
            for (int i = 0; i < word.Length; i++)
            {
                wordFrequency[word[i] - 'a']++;
                if (curMax < wordFrequency[word[i] - 'a'])
                {
                    curMax = wordFrequency[word[i] - 'a'];
                }
            }

            for (int i = 0; i < wordFrequency.Length; i++)
            {
                if (wordFrequency[i] != 0)
                {
                    f[pos] = wordFrequency[i];
                    break;
                }
            }
        }
    }
}
