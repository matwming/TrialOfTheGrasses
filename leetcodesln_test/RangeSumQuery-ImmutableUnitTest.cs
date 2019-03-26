using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RangeSumQuery_ImmutableUnitTest
    {
        public RangeSumQuery_Immutable RangeSumQuery_Immutable { get; set; }


        [TestMethod, Timeout(20_000)]
        [DataRow(0, 2, 1)]
        [DataRow(2, 5, -1)]
        [DataRow(0, 5, -3)]
        public void TestMethod1(int i, int j, int sum)
        {
            var input = new int[] { -2, 0, 3, -5, 2, -1 };
            RangeSumQuery_Immutable = new RangeSumQuery_Immutable(input);
            Assert.AreEqual(sum, RangeSumQuery_Immutable.SumRange(i, j));

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { -1 };
            RangeSumQuery_Immutable = new RangeSumQuery_Immutable(input);
            var expected = -1;
            var actual = RangeSumQuery_Immutable.SumRange(0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        [DataRow(0, 2, -1)]
        [DataRow(1, 2, -2)]
        [DataRow(0, 1, 5)]
        public void TestMethod3(int i, int j, int sum)
        {
            var input = new int[] { 1, 4, -6 };
            RangeSumQuery_Immutable = new RangeSumQuery_Immutable(input);
            Assert.AreEqual(sum, RangeSumQuery_Immutable.SumRange(i, j));

        }

        [TestCleanup]
        public void AfterEach()
        {
            RangeSumQuery_Immutable = null;
        }
    }
}
