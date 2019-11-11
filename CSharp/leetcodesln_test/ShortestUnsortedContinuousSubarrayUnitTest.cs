using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ShortestUnsortedContinuousSubarrayUnitTest
    {
        public ShortestUnsortedContinuousSubarray ShortestUnsortedContinuousSubarray;

        [TestInitialize]
        public void BeforeEach()
        {
            ShortestUnsortedContinuousSubarray = new ShortestUnsortedContinuousSubarray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 6, 4, 8, 10, 9, 15 };
            var expected = 5;
            var actual = ShortestUnsortedContinuousSubarray.FindUnsortedSubarray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 3, 2, 2, 2 };
            var expected = 4;
            var actual = ShortestUnsortedContinuousSubarray.FindUnsortedSubarray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] {1,2,3,4 };
            var expected = 0;
            var actual = ShortestUnsortedContinuousSubarray.FindUnsortedSubarray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
