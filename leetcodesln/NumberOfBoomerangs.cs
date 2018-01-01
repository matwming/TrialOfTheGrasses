using System.Collections.Generic;

namespace leetcodesln
{
    public class NumberOfBoomerangs
    {
        public int NumberOfBoomerangsSln(int[,] points)
        {
            int dim1 = points.GetLength(0); //get the length of the first dimension
            int count = 0;

            for (int i = 0; i < dim1; i++)
            {
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                for (int j = 0; j < dim1; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    int distant = (points[i, 0] - points[j, 0]) * (points[i, 0] - points[j, 0]) + (points[i, 1] - points[j, 1]) * (points[i, 1] - points[j, 1]);

                    if (!dictionary.ContainsKey(distant))
                    {
                        dictionary.Add(distant,1);
                    }
                    else
                    {
                        dictionary[distant]++;
                    }
                }

                foreach (var item in dictionary.Values)
                {
                    if (item >=2)
                    {
                        count += item * (item - 1);
                    }
                }
            }
            return count;
        }
    }
}