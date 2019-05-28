namespace leetcodesln
{
    public class PreviousPermutationWithOneSwap
    {
        public int[] PrevPermOpt1(int[] A)
        {
            int s1 = A.Length - 1;
            for (; s1 > 0 && A[s1] >= A[s1 - 1]; --s1) ;
            if (s1 == 0) return A;
            --s1;

            int s2 = A.Length - 1;
            for (; A[s2] >= A[s1] || A[s2]==A[s2-1]; --s2) ;   //找到第一个递增位之后从后面开始找最大的数（因为之前都是递减，所以找到第一个比第一递增位小的就可以交换）
            var temp = A[s1];
            A[s1] = A[s2];
            A[s2] = temp;
            return A;
        }
    }
}
