package questions;

/**
 * Created by user3301 on 9/1/2017.
 * Write a function that takes a string as input and returns the string reversed.

 Example:
 Given s = "hello", return "olleh".
 *
 */
public class ReverseString {

    public String reverseString(String s) {
        return new StringBuilder(s).reverse().toString();
    }
}
