namespace leetcodesln
{
    public class PreviousPermutationWithOneSwap
    {
        public int[] PrevPermOpt1(int[] A)
        {
            int maxIndex = A.Length -1;
            int? index = null;
            bool found = false;
            for (int i = A.Length - 1; i > 0; i--)
            {
                if(A[i-1] >= A[i])
                {
                    maxIndex = A[maxIndex] > A[i] ? maxIndex : i;
                    index = i - 1;
                    found = true;
                }
                else
                {
                    if (!found) continue;
                    else break;
                }
            }
            if(found)
            {
                var temp = A[maxIndex];
                A[maxIndex] = A[index.Value];
                A[index.Value] = temp;
            }

            return A;
        }
    }
}
