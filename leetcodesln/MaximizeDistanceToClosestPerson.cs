using System.Collections.Generic;

namespace leetcodesln
{
    public class MaximizeDistanceToClosestPerson
    {
        public int MaxDistToClosest(int[] seats)
        {
            var maxDistance = 0;

            var distanceMapLeft = new Dictionary<int, int>();
            var distanceMapRight = new Dictionary<int, int>();


            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0)
                {
                    var left = MaxDistanceLeft(seats, i, distanceMapLeft);
                    var right = MaxDistanceRight(seats, i, distanceMapRight);
                    var max = 0;
                    if (left != 0 && right != 0)
                    {
                        max = left > right ? right : left;

                    }
                    else if (left == 0)
                    {
                        max = right;
                    }
                    else if (right == 0)
                    {
                        max = left;
                    }
                    maxDistance = maxDistance > max ? maxDistance : max;
                }

            }
            return maxDistance;
        }

        private int MaxDistanceLeft(int[] seats, int position, Dictionary<int, int> dp)
        {

            if (dp.ContainsKey(position)) return dp.GetValueOrDefault(position);

            if (position == 0) return 0;
            if (seats[position - 1] == 1) return 1;

            return MaxDistanceLeft(seats, position - 1, dp) + 1;
        }

        private int MaxDistanceRight(int[] seats, int position, Dictionary<int, int> dp)
        {

            if (dp.ContainsKey(position)) return dp.GetValueOrDefault(position);

            if (position == seats.Length - 1) return 0;
            if (seats[position + 1] == 1) return 1;

            return MaxDistanceRight(seats, position + 1, dp) + 1;
        }
    }
}
