using System.Collections.Generic;

namespace leetcodesln
{
    public class BuddyStrings
    {
        public bool BuddyStringsSln(string A, string B)
        {
            if (A.Length != B.Length) return false;

            if (A == B && A.Length >= 2)
            {
                var dict = new Dictionary<char, int>();
                foreach (var chr in A)
                {
                    if (dict.ContainsKey(chr))
                    {
                        return true;
                    }
                    else dict.Add(chr, 1);
                }
                return false;

            }
            else
            {
                var list = new List<char>();

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != B[i])
                    {
                        list.Add(A[i]);
                        list.Add(B[i]);
                    }
                }
                return list.Count == 4 && list[1] == list[2] && list[0] == list[3];
            }
        }
    }
}