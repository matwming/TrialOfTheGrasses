using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PartitionLablesUnitTest
    {
        public PartitionLabels PartitionLabels { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PartitionLabels = new PartitionLabels();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "ababcbacadefegdehijhklij";
            var expected = new[] { 9, 7, 8 };
            var actual = PartitionLabels.PartitionLabelsSln(s);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
