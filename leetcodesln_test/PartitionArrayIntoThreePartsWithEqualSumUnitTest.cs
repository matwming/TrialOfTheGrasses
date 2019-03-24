using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PartitionArrayIntoThreePartsWithEqualSumUnitTest
    {
        public PartitionArrayIntoThreePartsWithEqualSum PartitionArrayIntoThreePartsWithEqualSum { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PartitionArrayIntoThreePartsWithEqualSum = new PartitionArrayIntoThreePartsWithEqualSum();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 };
            Assert.IsTrue(PartitionArrayIntoThreePartsWithEqualSum.CanThreePartsEqualSum(input));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 };
            Assert.IsFalse(PartitionArrayIntoThreePartsWithEqualSum.CanThreePartsEqualSum(input));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 };
            Assert.IsTrue(PartitionArrayIntoThreePartsWithEqualSum.CanThreePartsEqualSum(input));
        }
    }
}
