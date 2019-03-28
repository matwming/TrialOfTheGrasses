namespace leetcodesln
{
    public class VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var dict = new int[256];
            for (int i = 0; i < order.Length; i++)
            {
                dict[order[i]] = i;
            }

            for (int i = words.Length - 1; i > 0; i--)
            {
                if (CompareTwo(words[i], words[i - 1], ref dict)) continue;
                else return false;
            }
            return true;
        }

        private bool CompareTwo(string right, string left, ref int[] dict)
        {

            for (int i = 0; i <= (left.Length >= right.Length ? left.Length - 1 : right.Length - 1); i++)
            {
                if (i >= left.Length) return true;
                if (i < right.Length && i < left.Length && dict[right[i]] > dict[left[i]]) return true;
                else if (i < right.Length && i < left.Length && dict[right[i]] == dict[left[i]])
                {
                    continue;
                }
                else return false;
            }
            throw null;
        }
    }
}
