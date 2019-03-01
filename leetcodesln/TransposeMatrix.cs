namespace leetcodesln
{
    public class TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            var resultMatrix = new int[A[0].Length][];
            for (int i = 0; i < resultMatrix.Length; i++)
            {
                resultMatrix[i] = new int[A.Length];
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {

                    resultMatrix[j][i] = A[i][j];
                }
            }
            return resultMatrix;
        }
    }
}
