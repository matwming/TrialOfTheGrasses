package questions;

/**
 * Created by user3301 on 9/6/2017.
 */
public class AddDigits {

    //with for loop and recursive
    public int addDigits(int num) {
        String str=Integer.toString(num);
        int sum = 0;
        for (Object o : str.toCharArray()) {
            sum += Integer.parseInt(o.toString());
        }
        if(sum>=10) {
            return addDigits(sum);
        }
        return sum;
    }

    //without loop or recursive
    //每9个一循环，所有大于9的数的树根都是对9取余，那么对于等于9的数对9取余就是0了，为了得到其本身，而且同样也要对大于9的数适用，我们就用(n-1)%9+1这个表达式来包括所有的情况
//    public int addDigits(int num) {
//        return (num - 1) % 9 + 1;
//    }


}
