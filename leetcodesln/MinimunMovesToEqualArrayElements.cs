using System.Linq;

namespace leetcodesln
{
    public class MinimumMovesToEqualArrayElements 
    {
        public int MinMoves(int[] nums)
        {
            int max = nums.Max();
            int count = 0;
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            while(max * nums.Length != total) {
            if (max * nums.Length > total)
            {
                total += nums.Length -1;
                count++;
            }
            else if (max * nums.Length < total)
            {
                max++;
                total += nums.Length-1;
                count++;
            }
            }
            return count;
        }
        
    }
}