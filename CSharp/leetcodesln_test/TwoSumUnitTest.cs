using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TwoSumUnitTest
    {
        public TwoSum TwoSum { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            TwoSum = new TwoSum();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 1, 0 };
            var actual = TwoSum.TwoSumSln(input, target);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] {3,3};
            var target = 6;
            var expected = new int[] { 1,0 };
            var actual = TwoSum.TwoSumSln(input, target);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
