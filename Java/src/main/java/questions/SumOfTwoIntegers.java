package questions;

/**
 * Created by user3301 on 9/6/2017.
 */
public class SumOfTwoIntegers {

    public int getSum(int a, int b) {
        if(b==0) {return a;}
        int sum,carrry;
        sum = a^b;
        carrry = (a&b)<<1;
        return getSum(sum,carrry);
    }
}
