using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class LastStoneWeight
    {

        // keep stones sorted when new stones added using sortedDictionary
        public int LastStoneWeightSln(int[] stones)
        {
            var sortedDictionary = new SortedDictionary<int, int>();

            foreach (var stone in stones)
            {
                if (sortedDictionary.ContainsKey(stone)) sortedDictionary[stone]++;
                else sortedDictionary.Add(stone, 1);
            }

            while(sortedDictionary.Count >= 2)
            {
                var large = sortedDictionary.Last();
                sortedDictionary.Remove(large.Key);

                // if current max stones are even number, they will destroy each other, otherwise we need take out 
                if(large.Value % 2 == 1)
                {
                    var next = sortedDictionary.Last();
                    if (next.Value == 1) sortedDictionary.Remove(next.Key);
                    else sortedDictionary[next.Key]--;

                    if (sortedDictionary.ContainsKey(large.Key - next.Key)) sortedDictionary[large.Key - next.Key]++;
                    else sortedDictionary.Add(large.Key - next.Key, 1);
                }
            }
            var remain = sortedDictionary.First();
            return remain.Value%2==0?0:remain.Key;
        }
    }
}
