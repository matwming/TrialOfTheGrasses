namespace leetcodesln
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            // swap the symmetry
            for (int i = 0; i < n; i++)
            {
                for (int j = i; i < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // every rows swap left with right
            for (int i = 0; i < n; ++i)
            {
                int l = 0, r = matrix[i].Length - 1;
                while (l < r)
                {
                    var temp = matrix[i][l];
                    matrix[i][l] = matrix[i][r];
                    matrix[i][r] = temp;
                    l++;
                    r--;
                }
            }
        }
    }
}
