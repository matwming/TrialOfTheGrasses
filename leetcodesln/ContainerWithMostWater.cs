﻿using System;

namespace leetcodesln
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1, max = 0;

            while (l < r)
            {
                max = Math.Max(max, Math.Min(height[l], height[r]) * (r - l));
                if (height[l] > height[r]) --r;
                else ++l;
            }
            return max;
        }
    }
}
