using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class CarPooling
    {
        public bool CarPoolingSln(int[][] trips, int capacity)
        {
            int[] hopOnAndOff = new int[1000];

            for (int i = 0; i < trips.Length; i++)
            {
                var passangers = trips[i][0];
                hopOnAndOff[trips[i][1]] += passangers;
                hopOnAndOff[trips[i][2]] -= passangers;
            }

            var currentCapacity = 0;
            for (int i = 0; i < hopOnAndOff.Length; i++)
            {
                currentCapacity += hopOnAndOff[i];
                if (currentCapacity > capacity) return false;
            }
            return true;
        }
    }
}
