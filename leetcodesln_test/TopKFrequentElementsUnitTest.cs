using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class TopKFrequentElementsUnitTest
    {
        public TopKFrequentElements TopKFrequentElements { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            TopKFrequentElements = new TopKFrequentElements();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            var expected = new[] { 1, 2 };
            var actual = TopKFrequentElements.TopKFrequent(nums, k);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
