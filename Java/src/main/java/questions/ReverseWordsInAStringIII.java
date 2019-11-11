package questions;

/**
 * Created by user3301 on 9/1/2017.
 *
 * Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 Example 1:
 Input: "Let's take LeetCode contest"
 Output: "s'teL ekat edoCteeL tsetnoc"
 */
public class ReverseWordsInAStringIII {

    public String reverseWords(String s) {
        String[] words = s.split(" ");
        StringBuffer output = new StringBuffer();
        for (String word : words) {
            output.append(new StringBuilder(word).reverse().toString());
            output.append(" ");
        }
        output.deleteCharAt(output.length()-1);
        return output.toString();
    }

    public static void main(String[] args) {
        ReverseWordsInAStringIII reverseWordsInAStringIII = new ReverseWordsInAStringIII();
        String input = "Let's take LeetCode contest";
        System.out.println(reverseWordsInAStringIII.reverseWords(input));
    }
}
