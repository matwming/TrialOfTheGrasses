package questions;



/**
 * Created by user3301 on 9/11/2017.
 *
 *   important lesson: java generics does not work with primitives(toCharArray() yields a char[] instead of Character[])
 *   原理就是列出了magazine的字母表，然后算出了出现个数，然后遍历ransomNote，保证有足够的字母可用
 */
public class RansomNote {

    public boolean canConstruct(String ransomNote, String magazine) {
        int[] arr = new int[26];
        for (int i = 0; i < magazine.length(); i++) {
            arr[magazine.charAt(i) - 'a']++;
        }
        for (int i = 0; i < ransomNote.length(); i++) {
            if(--arr[ransomNote.charAt(i)-'a'] < 0) {
                return false;
            }
        }
        return true;
    }



    public static void main(String[] args) {
        RansomNote ransomNote = new RansomNote();
        System.out.println(ransomNote.canConstruct("bjaajgea","affhiiicabhbdchbidghccijjbfjfhjeddgggbajhidhjchiedhdibgeaecffbbbefiabjdhggihccea"));
    }
}
