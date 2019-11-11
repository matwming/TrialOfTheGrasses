package questions;

/**
 * Created by user3301 on 9/16/2017.
 */
public class TwoSumII {

//    /**
//     *  this answer will exceed the time limite if the array is like {0,0,0,0,0...........,7}, target 7
//     * @param numbers
//     * @param target
//     * @return
//     */
//    public int[] twoSum(int[] numbers, int target) {
//        int[] solution = new int[2];
//        for (int i = 0; i < numbers.length; i++) {
//            for (int j = i + 1; j < numbers.length; j++) {
//                if (numbers[j] == target - numbers[i]) {
//                    solution[0] = i + 1;
//                    solution[1] = j + 1;
//                    return solution;
//                }
//            }
//        }
//        return solution;
//    }

    public int[] twoSum(int[] numbers, int target) {
        int head = 0;
        int tail = numbers.length-1;
        while (head!=tail) {
            if(target == numbers[head] + numbers[tail]) {
                return new int[] {head+1,tail+1};
            }
            else if(target > numbers[head] + numbers[tail]) {
                head++;
            }
            else {
                tail--;
            }
        }
        return null;
    }

    public static void main(String[] args) {
        TwoSumII twoSumII = new TwoSumII();
        int[] res = twoSumII.twoSum(new int[]{2, 3, 4}, 6);
        for (int re : res) {
            System.out.println(re);
        }
    }
}
