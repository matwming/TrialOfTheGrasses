using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class KNearestPostOffice
    {
        public int[][] NearestOffices(int[][] post_offices, int k, int[] position)
        {
            if (post_offices.Length < k) throw new System.Exception();

            var ans = new int[k][];

            var d = new SortedDictionary<int, IList<int[]>>();

            for (int i = 0; i < post_offices.Length; i++)
            {
                var x = post_offices[i][0];
                var y = post_offices[i][1];
                var distant = (x - position[0]) * (x - position[0]) + (y - position[1]) * (y - position[1]);
                if (d.ContainsKey(distant))
                {
                    d.GetValueOrDefault(distant).Add(new[] { x, y });
                }
                else
                {
                    d.Add(distant, new List<int[]> { new[] { x, y } });
                }
            }

            var counter = 0;
            while (counter < k)
            {
                var pop = d.First().Value;
                foreach (var item in pop)
                {
                    ans[counter++] = item;
                    if (counter >= k) break;
                }
                d.Remove(d.First().Key);
            }
            return ans;
        }
    }
}