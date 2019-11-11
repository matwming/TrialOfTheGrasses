package questions;

/**
 * Created by user3301 on 8/18/2017.
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.

     You may assume that each input would have exactly one solution, and you may not use the same element twice.

     Example:
     Given nums = [2, 7, 11, 15], target = 9,

     Because nums[0] + nums[1] = 2 + 7 = 9,
     return [0, 1].
 */
public class TwoSum {

    public int[] findIndices(int[] input , int target) {
        for (int i = 0; i < input.length; i++) {
            for (int j = i+1; j < input.length ; j++) {
                if(input[i] + input[j] == target) {

                    return new int[] {i,j};
                }
            }
        }
        throw new IllegalArgumentException("no result!");
    }

    public static void main(String[] args) {
        int[] input = {2,7,11,15};
        int target = 55;
        TwoSum twoSum = new TwoSum();
        int[] t = twoSum.findIndices(input,target);
        for (int i : t) {
            System.out.println(i);
        }
    }

}
