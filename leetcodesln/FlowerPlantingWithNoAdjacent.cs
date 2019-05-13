using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class FlowerPlantingWithNoAdjacent
    {
        public int[] GardenNoAdj(int N, int[][] paths)
        {
            int[] ans = new int[N];

            List<int>[] g = new List<int>[N];
            for (int i = 0; i < N; i++)
            {
                g[i] = new List<int>();
            }

            foreach (var path in paths)
            {
                g[path[0] - 1].Add(path[1] - 1);
                g[path[1] - 1].Add(path[0] - 1);
            }

            for (int i = 0; i < N; i++)
            {
                bool[] used = new bool[5];
                foreach (var j in g[i]) used[ans[j]] = true;
                for (int j = 1; j <= 4; j++)
                {
                    if (!used[j]) ans[i] = j;
                }
            }
            return ans;
        }
    }
}