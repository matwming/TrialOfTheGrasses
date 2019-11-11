package questions;

import java.util.*;

/**
 * Created by user3301 on 9/1/2017.
 */
public class KeyboardRow {
    public String[] findWords(String[] words) {
        List<String> list = new ArrayList<>();
        for (String word : words) {
            if(word.toLowerCase().matches("[qwertyuiop]+")||word.toLowerCase().matches("[asdfghjkl]+")||word.toLowerCase().matches("[zxcvbnm]+")) {
                list.add(word);
            }
        }
        String[] result = new String[list.size()];
        for (int i = 0; i < list.size(); i++) {
            result[i] = list.get(i);
        }
        return result;
    }

    public static void main(String[] args) {
        KeyboardRow keyboardRow = new KeyboardRow();
        String[] words = {"Hello", "Alaska", "Dad", "Peace","aaaaa"};
        String[] result = keyboardRow.findWords(words);
        for (String s : result) {
            System.out.println(s);
        }
    }
}
