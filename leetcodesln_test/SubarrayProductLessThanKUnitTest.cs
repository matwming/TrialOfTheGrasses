using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SubarrayProductLessThanKUnitTest
    {
        public SubarrayProductLessThanK SubarrayProductLessThanK { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SubarrayProductLessThanK = new SubarrayProductLessThanK();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 10, 5, 2, 6 };
            var k = 100;
            var expected = 8;
            var actual = SubarrayProductLessThanK.NumSubarrayProductLessThanK(nums, k);
            Assert.AreEqual(expected, actual);
        }

    }
}
