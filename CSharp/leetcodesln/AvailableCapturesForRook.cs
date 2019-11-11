namespace leetcodesln
{
    public class AvailableCapturesForRook
    {
        public int NumRookCaptures(char[][] board)
        {
            var cord = (x: -1, y: -1);
            var captured = 0;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        cord = (i, j);
                        break;
                    }
                }
            }

            Captured(ref captured, cord, board);
            return captured;
        }

        private void Captured(ref int captured, (int x, int y) cord, char[][] board)
        {
            GoUp(ref captured, cord, board);
            GoDown(ref captured, cord, board);
            GoLeft(ref captured, cord, board);
            GoRight(ref captured, cord, board);
        }

        private void GoLeft(ref int captured, (int x, int y) cord, char[][] board)
        {
            if (cord.x < 0) return;
            if (board[cord.x][cord.y] == 'B') return;
            if (board[cord.x][cord.y] == 'p')
            {
                captured++;
                return;
            }

            GoLeft(ref captured, (cord.x - 1, cord.y), board);
        }

        private void GoRight(ref int captured, (int x, int y) cord, char[][] board)
        {
            if (cord.x >= board[0].Length) return;
            if (board[cord.x][cord.y] == 'B') return;
            if (board[cord.x][cord.y] == 'p')
            {
                captured++;
                return;
            }

            GoRight(ref captured, (cord.x + 1, cord.y), board);
        }

        private void GoUp(ref int captured, (int x, int y) cord, char[][] board)
        {
            if (cord.y >= board.Length) return;
            if (board[cord.x][cord.y] == 'B') return;
            if (board[cord.x][cord.y] == 'p')
            {
                captured++;
                return;
            }

            GoUp(ref captured, (cord.x, cord.y + 1), board);
        }

        private void GoDown(ref int captured, (int x, int y) cord, char[][] board)
        {
            if (cord.y < 0) return;
            if (board[cord.x][cord.y] == 'B') return;
            if (board[cord.x][cord.y] == 'p')
            {
                captured++;
                return;
            }

            GoDown(ref captured, (cord.x, cord.y - 1), board);
        }
    }
}