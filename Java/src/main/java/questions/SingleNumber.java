package questions;

import java.util.Stack;

/**
 * Created by user3301 on 9/4/2017.
 *
 * Given an array of integers, every element appears twice except for one. Find that single one.

 Note:
 Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
 */
public class SingleNumber {

    public int singleNumber(int[] nums) {
        Stack stack = new Stack();
        for (int i = 0; i < nums.length; i++) {
            if(stack.contains(nums[i]))  {
                stack.removeElement(nums[i]);
            }
            else
            {
                stack.push(nums[i]);
            }

        }
        return (int) stack.pop();
    }

    public static void main(String[] args) {
        SingleNumber singleNumber = new SingleNumber();
        int[] nums = {2,2,1,1,3,3,4,4,5,6,6};
        System.out.println(singleNumber.singleNumber(nums));
    }
}
