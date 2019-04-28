using System;

namespace leetcodesln
{
    public class MovingStonesUntilConsecutive
    {
        public int[] NumMovesStones(int a, int b, int c)
        {
            int[] ans = new int[2];
            int[] arr = new int[] { a, b, c };
            Array.Sort(arr);

            ans[0] = MinSteps(arr[0], arr[1], arr[2]);
            ans[1] = arr[1] - arr[0] - 1 + (arr[2] - arr[1] - 1);
            return ans;
        }


        // good one
        private int MinSteps(int a, int b, int c)
        {
            int left = b - a - 1;
            int right = c - b - 1;
            //                   xx___x              x____xx                    x_x_x
            return Math.Min((left > 0 ? 1 : 0) + (right > 0 ? 1 : 0), (left == 1 || right == 1 ? 1 : 2));
        }

        // not so good one
        //private int MinSteps(int a, int b, int c)
        //{
        //    if (a + 1 == b && b + 1 == c) return 0;
        //    if (a + 1 != b && b + 1 == c) return 1;
        //    if (a + 2 == b || b + 2 == c) return 1;
        //    if (a + 1 == b && b + 1 != c) return 1;
        //    else return 2;
        //}
    }
}
