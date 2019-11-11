package questions;

/**
 * Created by user3301 on 10/6/2017.
 */
public class ValidAnagram {

    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }
        char[] c = new char['z' - 'a' + 1];
        for (int i = 0; i < s.length(); i++) {
            c[s.charAt(i) - 'a']++;
            c[t.charAt(i) - 'a']--;
        }
        int count = 0;
        for (char c1 : c) {
            count += c1;
        }
        if (count != 0) {
            return false;
        }
        return true;
    }

    public static void main(String[] args) {
        ValidAnagram validAnagram = new ValidAnagram();
        boolean flag = validAnagram.isAnagram("", "");
        System.out.println(flag);
    }
}
