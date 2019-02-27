using System;

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
                    if(board[i][j] == 'R')
                    {
                        cord = (i,j);
                        break;
                    }
                }
            }

            Captured(ref captured, cord, board);
            return captured;
        }

        private void Captured(ref int captured, (int x, int y) cord, char[][] board)
        {
            if(board[cord.x][cord.y] == 'B') return;
            if(board[cord.x][cord.y] == 'p') captured++;

            if(cord.x -1 > 0 && cord.y >0 && cord.y < board.Length) Captured(ref captured, (cord.x -1, cord.y), board);
            if(cord.x + 1 < board[0].Length && cord.y >0 && cord.y < board.Length) Captured(ref captured, (cord.x + 1, cord.y), board);
            if(cord.y -1 > 0 && cord.x > 0 && cord.x< board[0].Length) Captured(ref captured, (cord.x, cord.y -1) , board);
            if(cord.y + 1 < board.Length && cord.x > 0 && cord.x < board[0].Length) Captured(ref captured, (cord.x, cord.y+1), board);
        }
    }
}