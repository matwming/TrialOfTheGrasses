using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ThreeSumClosestUnitTest
    {
        public ThreeSumClosest ThreeSumClosest { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ThreeSumClosest = new ThreeSumClosest();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 0, 1, 2 };
            var target = 3;
            var expected = 3;
            var actual = ThreeSumClosest.ThreeSumClosestSln(nums, target);
            Assert.AreEqual(expected, actual);
        }

    }
}
