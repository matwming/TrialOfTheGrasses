package questions;

import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.Map;

/**
 * Created by user3301 on 10/9/2017.
 */
public class RelativeRanks {

    public String[] findRelativeRanks(int[] nums) {
        Integer[] temp = new Integer[nums.length];
        for (int i = 0; i < temp.length; i++) {
            temp[i] = nums[i];
        }
        Arrays.sort(temp, Collections.reverseOrder());
        Map<Integer,Integer> map = new HashMap<>();
        for (int i = 0; i < temp.length; i++) {
            map.put(temp[i],i);
        }
        String[] result = new String[nums.length];
        for (int i = 0; i < nums.length; i++) {
            String a = Integer.toString(map.get(nums[i])).equals("0")?"Gold Medal":(Integer.toString(map.get(nums[i])).equals("1")?"Silver Medal":(Integer.toString(map.get(nums[i])).equals("2")?"Bronze Medal":Integer.toString(map.get(nums[i])+1)));
            result[i] = a;
        }
        return result;
    }

    public static void main(String[] args) {
        RelativeRanks relativeRanks = new RelativeRanks();
        String[] str = relativeRanks.findRelativeRanks(new int[]{10,3,8,9,4});
        for (int i = 0; i < str.length; i++) {
            System.out.println(str[i]);

        }
    }
}
