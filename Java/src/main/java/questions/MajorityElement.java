package questions;

import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.Map;

/**
 * Created by user3301 on 9/18/2017.
 */
public class MajorityElement {

    public int majorityElement(int[] nums) {
        Map<Integer, Integer> elementMap = new HashMap<>();
        for (int num : nums) {
            Integer count = elementMap.get(num);
            elementMap.put(num, count != null ? count + 1 : 0);
        }
        return Collections.max(elementMap.entrySet(), new Comparator<Map.Entry<Integer, Integer>>() {
            @Override
            public int compare(Map.Entry<Integer, Integer> o1, Map.Entry<Integer, Integer> o2) {
                return o1.getValue().compareTo(o2.getValue());
            }
        }).getKey();
    }
}
