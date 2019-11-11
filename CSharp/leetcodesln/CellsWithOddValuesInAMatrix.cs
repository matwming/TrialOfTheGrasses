namespace leetcodesln
{
    public class CellsWithOddValuesInAMatrix
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            int ans = 0;

            var matrix = new int[n, m];
            var isOdd = new bool[n, m];

            foreach (var p in indices)
            {
                var ri = p[0];
                var ci = p[1];

                for (int i = 0; i < n; ++i)
                {
                    matrix[ri, i] += 1;
                    ans += Increament(ref isOdd, matrix, ri, i);
                }
                for (int j = 0; j < m; ++j)
                {
                    matrix[j, ci] += 1;
                    ans += Increament(ref isOdd, matrix, j, ci);
                }
            }
            return ans;
        }

        private int Increament(ref bool[,] isOdd, int[,] matrix, int x, int y)
        {
            if (isOdd[x, y])
            {
                if (matrix[x, y] % 2 == 0)
                {
                    isOdd[x, y] = false;
                    return -1;
                }
            }
            else
            {
                if (matrix[x, y] % 2 != 0)
                {
                    isOdd[x, y] = false;
                    return 1;
                }
            }
            return 0;
        }
    }
}
