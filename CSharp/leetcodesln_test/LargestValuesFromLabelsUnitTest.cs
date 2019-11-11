using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LargestValuesFromLabelsUnitTest
    {
        public LargestValuesFromLabels LargestValuesFromLabels { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LargestValuesFromLabels = new LargestValuesFromLabels();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var values = new int[] { 5, 4, 3, 2, 1 };
            var labels = new int[] { 1, 1, 2, 2, 3 };
            var num_wanted = 3;
            var use_limit = 1;
            var expected = 9;
            var actual = LargestValuesFromLabels.LargestValsFromLabels(values, labels, num_wanted: num_wanted, use_limit: use_limit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var values = new int[] { 5, 4, 3, 2, 1 };
            var labels = new int[] { 1, 3, 3, 3, 2 };
            var num_wanted = 3;
            var use_limit = 2;
            var expected = 12;
            var actual = LargestValuesFromLabels.LargestValsFromLabels(values, labels, num_wanted: num_wanted, use_limit: use_limit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var values = new int[] { 9, 8, 8, 7, 6 };
            var labels = new int[] { 0, 0, 0, 1, 1 };
            var num_wanted = 3;
            var use_limit = 1;
            var expected = 16;
            var actual = LargestValuesFromLabels.LargestValsFromLabels(values, labels, num_wanted: num_wanted, use_limit: use_limit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var values = new int[] { 9, 8, 8, 7, 6 };
            var labels = new int[] { 0, 0, 0, 1, 1 };
            var num_wanted = 3;
            var use_limit = 2;
            var expected = 24;
            var actual = LargestValuesFromLabels.LargestValsFromLabels(values, labels, num_wanted: num_wanted, use_limit: use_limit);
            Assert.AreEqual(expected, actual);
        }

    }
}
