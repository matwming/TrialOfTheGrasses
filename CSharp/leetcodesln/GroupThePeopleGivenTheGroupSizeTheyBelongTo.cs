using System.Collections.Generic;

namespace leetcodesln
{
    public class GroupThePeopleGivenTheGroupSizeTheyBelongTo
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var ans = new List<IList<int>>();

            var map = new Dictionary<int, IList<int>>();

            for (int i = 0; i < groupSizes.Length; ++i)
            {
                if (map.ContainsKey(groupSizes[i]))
                {
                    map[groupSizes[i]].Add(i);
                }
                else
                {
                    map.Add(groupSizes[i], new List<int> { i });
                }
                if (map[groupSizes[i]].Count == groupSizes[i])
                {
                    ans.Add(map[groupSizes[i]]);
                    map[groupSizes[i]] = new List<int>();
                }
            }

            return ans;
        }
    }
}
