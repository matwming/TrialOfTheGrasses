package questions;


/**
 * Created by user3301 on 9/11/2017.
 */
public class ExcelSheetColumnNumber {

    public int titleToNumber(String s) {
        char[] charArr = s.toCharArray();
        int columnNumber = 0;
        for (int i = 0; i < charArr.length; i++) {
            if (i == charArr.length - 1) {
                columnNumber += charArr[i] % 64;
            } else {
                columnNumber += (charArr[i] % 64) * Math.pow(26, charArr.length - 1 - i);
            }
        }
        return columnNumber;
    }

    public static void main(String[] args) {
        ExcelSheetColumnNumber excelSheetColumnNumber = new ExcelSheetColumnNumber();
        System.out.println(excelSheetColumnNumber.titleToNumber("AJHX"));
    }
}
