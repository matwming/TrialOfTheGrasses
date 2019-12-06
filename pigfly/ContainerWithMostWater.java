// two pointers
class Solution {
  public int maxArea(int[] height) {
    if (height == null || height.length < 2) {
      return 0;
    }

    int max = 0;
    for (int i = 0, j = height.length - 1; i < j;) {
      int minHeight = height[i] < height[j] ? height[i++] : height[j--];
      int area = (j - i + 1) * minHeight;
      max = Integer.max(area, max);
    }

    return max;
  }
}
