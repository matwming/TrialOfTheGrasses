using System;
using System.Text;

namespace leetcodesln
{
    public class AlphabetBoardPath
    {
        public string AlphabetBoardPathSln(string target)
        {
            var sb = new StringBuilder();
            var pre = new[] { 0, 0 };
            foreach (var chr in target)
            {
                var a = (chr - 'a');
                var b = (chr - 'a');
                var cur = new[] { (chr - 'a') / 5, (chr - 'a') % 5 };
                // up before right, left before down
                var vertix = cur[0] - pre[0];
                var horizon = cur[1] - pre[1];

                if (vertix > 0)  // move down
                {
                    if (horizon < 0)
                    {
                        for (int i = 0; i < Math.Abs(horizon); i++)
                        {
                            sb.Append(horizon > 0 ? "R" : "L");
                        }
                        for (int i = 0; i < vertix; i++)
                        {
                            sb.Append("D");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < vertix; i++)
                        {
                            sb.Append("D");
                        }
                        for (int i = 0; i < Math.Abs(horizon); i++)
                        {
                            sb.Append(horizon > 0 ? "R" : "L");
                        }
                    }
                    sb.Append("!");
                    pre = cur;
                }
                else //vertix < 0
                {
                    for (int i = 0; i < Math.Abs(vertix); i++)
                    {
                        sb.Append(vertix > 0 ? "D" : "U");
                    }
                    for (int i = 0; i < Math.Abs(horizon); i++)
                    {
                        sb.Append(horizon > 0 ? "R" : "L");
                    }

                    sb.Append("!");
                    pre = cur;
                }
            }
            return sb.ToString();
        }
    }
}
