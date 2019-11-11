using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class FindAnagramMappings
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            Dictionary<int, int> HashMappingB = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++)
            { 
                HashMappingB.Add(i,B[i]);
            }
            int[] indexMapping = new int[A.Length];
            for (int i = 0; i < indexMapping.Length; i++)
            {
                foreach(KeyValuePair<int,int> pair in HashMappingB)
                {
                    if (pair.Value == A[i])
                    {
                        indexMapping[i] = pair.Key;
                        break;
                    }
                }
            }
            return indexMapping;
        }
    }
}
