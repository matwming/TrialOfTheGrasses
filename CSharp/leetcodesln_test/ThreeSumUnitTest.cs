using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class ThreeSumUnitTest
    {
        public ThreeSum ThreeSum { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ThreeSum = new ThreeSum();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var expected = new List<IList<int>>() { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } };
            var actual = ThreeSum.ThreeSumSln(nums);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var nums = new int[] { 0, 0, 0, 0 };
            var expected = new List<IList<int>>() { new List<int>() { 0, 0, 0 } };
            var actual = ThreeSum.ThreeSumSln(nums);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}
