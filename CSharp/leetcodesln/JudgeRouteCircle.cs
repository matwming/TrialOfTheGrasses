namespace leetcodesln
{
    public class JudgeRouteCircle
    {
        public bool JudgeRouteCircleSolution(string moves)
        {
            if(moves.Length==0 || moves==null)
            {
                return false;
            }
            double extraMoves = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        extraMoves+=1.0;
                        break;
                    case 'D':
                        extraMoves-=1.0;
                        break;
                    case 'R':
                        extraMoves += 1.5;
                        break;
                    case 'L':
                        extraMoves -= 1.5;
                        break;
                    default:
                        break;
                }
            }
            return extraMoves == 0;
        }
    }
}
