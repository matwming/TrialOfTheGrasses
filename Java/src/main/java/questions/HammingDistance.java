package questions;

/**
 * Created by user3301 on 8/22/2017.
 *
 * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

 Given two integers x and y, calculate the Hamming distance.

 Note:
 0 ≤ x, y < 231.

 Example:

 Input: x = 1, y = 4

 Output: 2

 Explanation:
 1   (0 0 0 1)
 4   (0 1 0 0)
 ?   ?

 The above arrows point to positions where the corresponding bits are different.
 */
public class HammingDistance {

    public int hammingDistance(int x, int y) {
        int counter = 0;
        int bigger = x>y?x:y;
        int smaller = x>y?y:x;
        String bigbinary = Integer.toBinaryString(bigger);
        String smallbinary = Integer.toBinaryString(smaller);
        for (int i = 0; i < bigbinary.length()-smallbinary.length(); i++) {
            if(bigbinary.charAt(i)=='1') {
                counter++;
            }
        }
        for (int j = 0; j < smallbinary.length(); j++) {
            if(bigbinary.charAt(bigbinary.length()-smallbinary.length()+j)!=smallbinary.charAt(j)) {
                counter++;
            }
        }
        return counter;
    }

    public static void main(String[] args) {
        HammingDistance hammingDistance = new HammingDistance();
        System.out.println(hammingDistance.hammingDistance(3,25));
    }
}
