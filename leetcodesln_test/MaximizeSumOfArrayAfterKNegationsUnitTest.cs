using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MaximizeSumOfArrayAfterKNegationsUnitTest
    {
        public MaximizeSumOfArrayAfterKNegations MaximizeSumOfArrayAfterKNegations { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MaximizeSumOfArrayAfterKNegations = new MaximizeSumOfArrayAfterKNegations();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = new int[] { 4, 2, 3 };
            var K = 1;
            var expected = 5;
            var actual = MaximizeSumOfArrayAfterKNegations.LargestSumAfterKNegations(A, K);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var A = new int[] { 3,-1,0,2 };
            var K = 3;
            var expected = 6;
            var actual = MaximizeSumOfArrayAfterKNegations.LargestSumAfterKNegations(A, K);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var A = new int[] { -2,9,9,8,4};
            var K = 5;
            var expected = 32;
            var actual = MaximizeSumOfArrayAfterKNegations.LargestSumAfterKNegations(A, K);
            Assert.AreEqual(expected, actual);
        }

    }
}
