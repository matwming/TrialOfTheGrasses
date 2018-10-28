using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln
{
    [TestClass]
    public class BinaryGapUnitTest
    {
        [TestMethod]
        public void BinaryGapTestMethod()
        {
            var binaryGap = new BinaryGap();
            var input1 = 22;
            var expected1 = 2;
            var actual1 = binaryGap.FindLongestBinaryGap(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = 5;
            var expected2 = 2;
            var actual2 = binaryGap.FindLongestBinaryGap(input2);
            Assert.AreEqual(expected2,actual2);

            var input3 = 6;
            var expected3 = 1;
            var actual3 = binaryGap.FindLongestBinaryGap(input3);
            Assert.AreEqual(expected3,actual3);
        }
    }
}