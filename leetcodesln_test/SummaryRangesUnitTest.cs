using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class SummaryRangesUnitTest
    {
        public SummaryRanges SummaryRanges { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SummaryRanges = new SummaryRanges();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 0, 1, 2, 4, 5, 7 };
            var expected = new List<string> { "0->2", "4->5", "7" };
            var actual = SummaryRanges.SummaryRangesSln(nums);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
