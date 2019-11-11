package questions;

/**
 * Created by user3301 on 9/3/2017.
 */
public class NextGreaterElementI {

    int getIndex(int x, int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == x) {
                return i;
            }
        }
        return -1;
    }

    public int[] nextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.length];
        for (int i = 0; i < result.length; i++) {
            result[i] = -1;
        }
        for (int i = 0; i < nums1.length; i++) {
            for (int j = getIndex(nums1[i], nums2); j < nums2.length; j++) {
                if (nums1[i] < nums2[j]) {
                    result[i] = nums2[j];
                    break;
                }
            }
        }
        return result;
    }
}
