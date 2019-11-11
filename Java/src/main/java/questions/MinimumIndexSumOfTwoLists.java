package questions;

import java.util.*;

/**
 * Created by user3301 on 10/10/2017.
 */
public class MinimumIndexSumOfTwoLists {

    public String[] findRestaurant(String[] list1, String[] list2) {
        Map<String,Integer> listMap1 = new HashMap<>();
        for (int i = 0; i < list1.length; i++) {
            listMap1.put(list1[i],i);
        }
        Map<String,Integer> listMap2 = new HashMap<>();
        for (int i = 0; i < list2.length; i++) {
            listMap2.put(list2[i],i);
        }
        HashSet<String> set1 = new HashSet<>(Arrays.asList(list1));
        HashSet<String> set2 = new HashSet<>(Arrays.asList(list2));
        set1.retainAll(set2);
        int minIndex = Integer.MAX_VALUE;
        List<String> list = new ArrayList<>();
        for (String s : set1) {
            if(listMap1.get(s)+listMap2.get(s)==minIndex) {
                minIndex = listMap1.get(s)+listMap2.get(s);
                list.add(s);
            }
            else if(listMap1.get(s)+listMap2.get(s)< minIndex) {
                minIndex = listMap1.get(s)+listMap2.get(s);
                list = new ArrayList<>();
                list.add(s);
            }
        }
        String[] result = new String[list.size()];
        for (int i = 0; i < list.size(); i++) {
            result[i] = list.get(i);

        }
        return result;
    }

    public static void main(String[] args) {
        MinimumIndexSumOfTwoLists m = new MinimumIndexSumOfTwoLists();
        String[] res = m.findRestaurant(new String[]{"shotgun","Tapioca Express","Burger King","KFC"},new String[]{"KFC","shotgun","Burger King"});
        for (String re : res) {
            System.out.println(re);
        }
    }
}
