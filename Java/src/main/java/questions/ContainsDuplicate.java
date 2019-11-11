package questions;

import java.util.HashSet;
import java.util.Set;

/**
 * Created by user3301 on 10/19/2017.
 */
public class ContainsDuplicate {

    // brutal force answer, excess time limits
//        public boolean containsDuplicate(int[] nums) {
//            for (int i = 0; i < nums.length; i++) {
//                for (int j = i; j < nums.length; j++) {
//                    if(nums[j] == nums[i]) {
//                        return true;
//                    }
//                }
//            }
//            return false;
//        }

    public boolean containsDuplicate (int[] nums) {
        Set<Integer> set = new HashSet<>();
        for (int num : nums) {
            set.add(num);
        }
        return set.size()<nums.length;
    }
}
