namespace leetcodesln
{
    public class DistributeCandiesToPeople
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            var ans = new int[num_people];

            int i = 1;
            while (candies > 0)
            {
                if (candies - i >= 0)
                {
                    ans[i % num_people == 0? num_people-1 : i%num_people -1] += i;
                    candies -= i;
                    i++;
                }
                else
                {
                    ans[i % num_people == 0 ? num_people-1 : i % num_people - 1] += candies;
                    candies = 0;
                }

            }
            return ans;
        }
    }
}
