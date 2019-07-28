using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class AlphabetBoardPath
    {
        private readonly char[][] _board = new char[][] {
            new char[] { 'a','b','c','d','e'},
            new char[] { 'f','g','h','i','j'},
            new char[] { 'k','l','m','n','o'},
            new char[] { 'p','q','r','s','t'},
            new char[] { 'u','v','w','x','y'},
            new char[] { 'z'},

        };

        public string AlphabetBoardPathSln(string target)
        {
            var sb = new StringBuilder();
            var moves = new List<int[]> { new[] { 0, 0 } };

            foreach (var chr in target)
            {
                if (chr >= 97 && chr <= 101)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (_board[0][i] == chr)
                        {
                            moves.Add(new[] { 0, i });
                            break;
                        }
                    }
                }
                if (chr >= 102 && chr <= 106)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (_board[1][i] == chr)
                        {
                            moves.Add(new[] { 1, i });
                            break;
                        }
                    }
                }
                if (chr >= 107 && chr <= 111)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (_board[2][i] == chr)
                        {
                            moves.Add(new[] { 2, i });
                            break;
                        }
                    }
                }
                if (chr >= 112 && chr <= 116)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (_board[3][i] == chr)
                        {
                            moves.Add(new[] { 3, i });
                            break;
                        }
                    }
                }
                if (chr >= 117 && chr <= 121)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (_board[4][i] == chr)
                        {
                            moves.Add(new[] { 4, i });
                            break;
                        }
                    }
                }
                if (chr == 122)
                {

                    moves.Add(new[] { 5, 0 });


                }
            }


            for (int i = 1; i < moves.Count; i++)
            {
                var curr = moves[i - 1];
                var dest = moves[i];
                var hor = dest[0] - curr[0];
                var ver = dest[1] - curr[1];
                if (hor >= 0)
                {
                    for (int j = 0; j < hor; j++)
                    {
                        sb.Append('D');
                    }
                }
                else
                {
                    for (int j = 0; j < -hor; j++)
                    {
                        sb.Append('U');
                    }
                }
                if (ver >= 0)
                {
                    for (int j = 0; j < ver; j++)
                    {
                        sb.Append('R');
                    }
                }
                else
                {
                    for (int j = 0; j < -ver; j++)
                    {
                        sb.Append('L');
                    }
                }
                sb.Append('!');
            }

            return sb.ToString();
        }
    }
}
