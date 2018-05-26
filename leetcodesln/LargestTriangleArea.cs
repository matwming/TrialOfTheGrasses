using System;
namespace leetcodesln
{
    public class LargestTriangleArea
    {
        public double MaxTriangleArea(int[][] points)
        {
            double result = 0.0;
            foreach (int[] i in points)
            {
                foreach (int[] j in points)
                {
                    foreach (int[] k in points)
                    {
                        result = Math.Max(result, 0.5 * Math.Abs(i[0] * j[1] + j[0] * k[1] + k[0] * i[1]- j[0] * i[1] - k[0] * j[1] - i[0] * k[1]));
                    }
                }
            }
            return result;
        }
    }
}