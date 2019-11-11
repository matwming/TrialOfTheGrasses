package questions;

import java.util.Arrays;

/**
 * Created by user3301 on 9/6/2017.
 */
public class FindTheDifference {


    public char findTheDifference(String s, String t) {
        char[] sArr = s.toCharArray();
        char[] tArr = t.toCharArray();
        Arrays.sort(sArr);
        Arrays.sort(tArr);
        for (int i = 0; i < sArr.length; i++) {
            if (sArr[i] != tArr[i]) {
                return tArr[i];
            }
        }
        return tArr[tArr.length - 1];

    }

    public static void main(String[] args) {
        FindTheDifference findTheDifference = new FindTheDifference();
        char res = findTheDifference.findTheDifference("abcd", "abcbd");
        System.out.println(res);
    }
}
