namespace leetcodesln
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool[,] row = new bool[9, 9];
            bool[,] col = new bool[9, 9];
            bool[,] box = new bool[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = board[i][j] - '0' - 1;
                        int b = i / 3 * 3 + j / 3;
                        if (row[i, num] || col[j, num] || box[b, num]) return false;
                        row[i, num] = col[j, num] = box[b, num] = true;
                    }
                }
            }
            return true;
        }
    }
}
