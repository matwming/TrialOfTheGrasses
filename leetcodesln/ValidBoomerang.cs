using System;

namespace leetcodesln
{
    public class ValidBoomerang
    {
        public bool IsBoomerang(int[][] points)
        {
            return !IsOnLineAndValid(points) && !IsOnDiagonalAndValid(points);
        }

        private bool IsOnDiagonalAndValid(int[][] points)
        {
            if (points[0][0] == points[1][0] && points[0][1] == points[1][1]) return true;  // point1 == point2 not valid 
            if (points[1][0] == points[2][0] && points[1][1] == points[2][1]) return true; // p2 == p3 not boomerang
            if (points[0][0] == points[2][0] && points[0][1] == points[2][1] && (points[0][0] - points[1][0] != points[0][1] - points[1][1])) return true; // point1==point3 but point2 not valid
            if ((points[0][0]-points[1][0]== points[0][1]-points[1][1]) && (points[0][0] - points[2][0] == points[0][1] - points[2][1])) return true;
            return false;
        }

        private bool IsOnLineAndValid(int[][] points)
        {
            if (points[0][0] == points[1][0] && points[0][1] == points[1][1]) return true;  // point1 == point2 not valid 
            if (points[1][0] == points[2][0] && points[1][1] == points[2][1]) return true; // p2 == p3 not boomerang

            if (points[0][0] == points[2][0] && points[0][1] == points[2][1] && (points[0][0] - points[1][0] != points[0][1] - points[1][1])) return true; // point1==point3 but point2 not valid
            if ((points[0][0] == points[1][0] && points[0][0] == points[2][0]) || (points[0][1] == points[1][1] && points[0][1] == points[2][1])) return true;
            return false;
        }
    }
}
