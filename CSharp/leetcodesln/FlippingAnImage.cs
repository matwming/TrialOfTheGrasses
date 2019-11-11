namespace leetcodesln
{
    public class FlippingAnImage
    {

        // complexity O(N^2)
        //public int[][] FlipAndInvertImage(int[][] A)
        //{
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        Array.Reverse(A[i]);
        //        for (int j = 0; j < A[i].Length; j++)
        //        {
        //            A[i][j] = 1 - A[i][j];
        //        }
        //    }
        //    return A;
        //}


        // in-place solution
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; ++i)
            {
                int left = 0, right = A[i].Length - 1;
                while (left <= right)
                {
                    var temp = A[i][right];
                    A[i][right] = (A[i][left] == 0 ? 1 : 0);
                    A[i][left] = (temp == 0 ? 1 : 0);
                    ++left;
                    --right;
                }
            }
            return A;
        }
    }
}
