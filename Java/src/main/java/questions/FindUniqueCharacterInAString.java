package questions;


/**
 * Created by Stan on 21/9/17.
 * <p>
 * Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
 * <p>
 * Examples:
 * <p>
 * s = "leetcode"
 * return 0.
 * <p>
 * s = "loveleetcode",
 * return 2.
 */
public class FindUniqueCharacterInAString {

    public int firstUniqChar(String s) {
        int[] frequency = new int[26];
        for (int i = 0; i < s.length(); i++) {
            frequency[s.charAt(i) - 'a']++;
        }
        for (int i = 0; i < s.length(); i++) {
            if (frequency[s.charAt(i) - 'a'] == 1) {
                return i;
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        FindUniqueCharacterInAString findUniqueCharacterInAString = new FindUniqueCharacterInAString();
        System.out.println(findUniqueCharacterInAString.firstUniqChar("leetcode"));
    }
}
