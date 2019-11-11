using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class MajorityElementIIUnitTest
    {
        public MajorityElementII MajorityElementII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MajorityElementII = new MajorityElementII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 3, 2, 3 };
            var expected = new List<int> { 3 };
            var actual = MajorityElementII.MajorityElement(nums);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var nums = new[] { 1, 1, 1, 3, 3, 2, 2, 2 };
            var expected = new List<int> { 1, 2 };
            var actual = MajorityElementII.MajorityElement(nums);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }
    }
}
