using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaximumProductOfThreeNumbersUnitTest
    {
        [TestMethod]
        public void MaximumProductOfThreeNumbersTestMethod()
        {
            var maximumProductOfThreeNumbers = new MaximumProductOfThreeNumbers();
            var input1 = new int[] {1,2,3};
            var expected1 = 6;
            var actual1 = maximumProductOfThreeNumbers.MaximumProduct(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = new int[] {1,2,3,-4,-5, -6,-7};
            var expected2 = 126;
            var actual2 = maximumProductOfThreeNumbers.MaximumProduct(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = new int[] {1,2,3,4};
            var expected3 = 24;
            var actual3 = maximumProductOfThreeNumbers.MaximumProduct(input3);
            Assert.AreEqual(expected3, actual3);

            var input4 = new int[] {-4,-3,-2,-1, 60};
            var expected4 = 720;
            var actual4 = maximumProductOfThreeNumbers.MaximumProduct(input4);
            Assert.AreEqual(expected4, actual4);

            var input5 = new int[] {722,634,-504,-379,163,-613,-842,-578,750,951,-158,30,-238,-392,-487,-797,-157,-374,999,-5,-521,-879,-858,382,626,803,-347,903,-205,57,-342,186,-736,17,83,726,-960,343,-984,937,-758,-122,577,-595,-544,-559,903,-183,192,825,368,-674,57,-959,884,29,-681,-339,582,969,-95,-455,-275,205,-548,79,258,35,233,203,20,-936,878,-868,-458,-882,867,-664,-892,-687,322,844,-745,447,-909,-586,69,-88,88,445,-553,-666,130,-640,-918,-7,-420,-368,250,-786};
            var expected5 = 943695360;
            var actual5 = maximumProductOfThreeNumbers.MaximumProduct(input5);
            Assert.AreEqual(expected5, actual5);
        }
    }
}