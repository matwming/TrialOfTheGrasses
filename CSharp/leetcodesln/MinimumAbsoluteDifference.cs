using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {

            Array.Sort(arr);

            var minAbsDist = int.MaxValue;

            for (int i = 0; i < arr.Length - 1; ++i)
            {
                minAbsDist = minAbsDist < Math.Abs(arr[i + 1] - arr[i]) ? minAbsDist : Math.Abs(arr[i + 1] - arr[i]);
            }

            var ans = new List<IList<int>>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] == minAbsDist) ans.Add(new List<int> { arr[i], arr[i + 1] });
            }

            return ans;
        }
    }
}
