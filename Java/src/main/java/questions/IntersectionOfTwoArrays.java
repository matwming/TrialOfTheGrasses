package questions;

import java.util.*;

/**
 * Created by Stan on 9/9/17.
 */
public class IntersectionOfTwoArrays {

    public int[] intersection(int[] nums1, int[] nums2) {

        if(nums1.length==0||nums2.length==0) {
            return new int[0];
        }
        Set<Integer> set1 = new HashSet<>();
        for (int i = 0; i < nums1.length; i++) {
            set1.add(nums1[i]);
        }
        List<Integer> result = new ArrayList<>();
        for (int i = 0; i < nums2.length; i++) {
            if(set1.contains(nums2[i])&&!result.contains(nums2[i])) {
                result.add(nums2[i]);
            }
        }
        int[] res = new int[result.size()];
        for (int i = 0; i < result.size(); i++) {
            res[i] = result.get(i);
        }
        return res;
    }
}
