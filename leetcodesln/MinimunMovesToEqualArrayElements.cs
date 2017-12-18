using System;
using System.Linq;

namespace leetcodesln
{
    public class MinimumMovesToEqualArrayElements 
    {
        public int MinMoves(int[] nums)
        {
            int min = nums.Min();
            return nums.Sum(x=>x-min);
        }
        
    }
}