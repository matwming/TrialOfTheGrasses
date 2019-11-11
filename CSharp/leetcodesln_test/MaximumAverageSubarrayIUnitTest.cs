using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaximumAverageSubarrayIUnitTest
    {
        public MaximumAverageSubarrayI maximumAverageSubarrayI { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            maximumAverageSubarrayI = new MaximumAverageSubarrayI();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] {1,12,-5,-6,50,3};
            var k = 4;
            var expected = 12.75;
            var actual = maximumAverageSubarrayI.FindMaxAverage(input, k);
            Assert.AreEqual(expected,actual);
        }
    }
}