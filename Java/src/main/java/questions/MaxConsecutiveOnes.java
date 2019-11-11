package questions;

import java.util.Stack;

/**
 * Created by user3301 on 9/4/2017.
 */
public class MaxConsecutiveOnes {


    public int findMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int temp = 0;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 1) {
                temp++;
            } else {
                temp = 0;
            }
            if (temp > max) {
                max = temp;
            }
        }
        return max;
    }
}
