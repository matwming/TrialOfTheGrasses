using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayIIUnitTest
    {
        public RemoveDuplicatesFromSortedArrayII RemoveDuplicatesFromSortedArrayII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RemoveDuplicatesFromSortedArrayII = new RemoveDuplicatesFromSortedArrayII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 1, 1, 1, 2, 2, 3 };
            var expected = 5;
            var actual = RemoveDuplicatesFromSortedArrayII.RemoveDuplicates(nums);
            Assert.AreEqual(expected, actual);
        }

    }
}
