package questions;

/**
 * Created by user3301 on 9/4/2017.
 */
public class DetectCapital {

    public boolean detectCapitalUse(String word) {
        if(word.length()<=1) {
            return true;
        }
        String remain = word.substring(1,word.length());
        return remain.matches("[qwertyuiopasdfghjklzxcvbnm]+")|| word.matches("[QWERTYUIOPASDFGHJKLZXCVBNM]+");
    }

    public static void main(String[] args) {
        DetectCapital detectCapital = new DetectCapital();
        detectCapital.detectCapitalUse("asdasd");
    }
}
