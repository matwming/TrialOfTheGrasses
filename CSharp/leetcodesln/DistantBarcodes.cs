using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class DistantBarcodes
    {
        public int[] RearrangeBarcodes(int[] barcodes)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < barcodes.Length; i++)
            {
                if (dict.ContainsKey(barcodes[i])) dict[barcodes[i]]++;
                else dict.Add(barcodes[i], 1);
            }

            var ans = new int[barcodes.Length];
            Array.Fill(ans, int.MaxValue);
            bool front = true;

            while(dict.Count!=0)
            {
                var max = -1;
                var maxKv = default(KeyValuePair<int, int>);
                foreach (var kv in dict)
                {
                    if(kv.Value > max)
                    {
                        maxKv = kv;
                        max = kv.Value;
                    }
                }

                int count = maxKv.Value;
                int elem = maxKv.Key;
                dict.Remove(elem);
                if (front)
                {
                    for (int j = 0; j < ans.Length && count != 0; j++)
                    {
                        if (ans[j] != int.MaxValue) continue;
                        else
                        {
                            ans[j] = elem;
                            count--;
                            j++;
                        }
                    }
                    front = false;
                }
                else
                {
                    for (int i = ans.Length - 1; i >= 0 && count != 0; i--)
                    {
                        if (ans[i] != int.MaxValue) continue;
                        else
                        {
                            ans[i] = elem;
                            count--;
                            i--;
                        }
                        front = true;
                    }
                }
            }


            return ans;
        }
    }
}
