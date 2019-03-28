namespace leetcodesln
{
    public class VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var dict = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                dict[order[i] - 'a'] = i;
            }

            for (int i = 1; i < words.Length; i++)
            {
                if (CompareTwo(words[i], words[i - 1]) < 0) return false;
            }
            return true;

            int CompareTwo(string right, string left)
            {
                var rLen = right.Length;
                var lLen = left.Length;
                var dis = 0;

                for (int l = 0, r = 0; l < lLen && r < rLen && dis == 0; l++, r++)
                {
                    dis = dict[right[r] - 'a'] - dict[left[l] - 'a'];
                }
                return dis == 0 ? rLen - lLen : dis;
            }
        }


    }
}
