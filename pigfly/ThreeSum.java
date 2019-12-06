// two pointers
class Solution {
  public List<List<Integer>> threeSum(int[] nums) {
    List<List<Integer>> result = new ArrayList<>();

    if (nums == null || nums.length < 3) {
      return result;
    }

    Arrays.sort(nums);
    for (int i = 0; i < nums.length - 2; i++) {
      // prevent checking duplicate again. (This seems to be a good pattern which has
      // been seen in other questions as well).
      if (i > 0 && nums[i] == nums[i - 1]) {
        continue;
      }

      for (int j = i + 1, k = nums.length - 1; j < k;) {
        int sum = nums[j] + nums[k];
        if (sum < -nums[i]) {
          j++;
        } else if (sum > -nums[i]) {
          k--;
        } else {
          result.add(Arrays.asList(nums[i], nums[j], nums[k]));
          while (j < k && nums[j] == nums[j + 1]) {
            j++;
          }
          while (j < k && nums[k] == nums[k - 1]) {
            k--;
          }
          j++;
          k--;
        }
      }
    }

    return result;
  }
}