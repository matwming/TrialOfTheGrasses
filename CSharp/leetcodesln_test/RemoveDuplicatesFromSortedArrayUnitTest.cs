using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayUnitTest
    {
        public RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] {1,1,2};
            var expected = 2;
            var actual = removeDuplicatesFromSortedArray.RemoveDuplicates(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] {0,0,1,1,1,2,2,3,3,4};
            var expected = 5;
            var actual = removeDuplicatesFromSortedArray.RemoveDuplicates(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}