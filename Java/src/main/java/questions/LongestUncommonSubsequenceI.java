package questions;

/**
 * Created by user3301 on 9/4/2017.
 */
public class LongestUncommonSubsequenceI {

    public int findLUSlength(String a, String b) {
        return a.equals(b)?-1:Math.max(a.length(),b.length());
    }
}
