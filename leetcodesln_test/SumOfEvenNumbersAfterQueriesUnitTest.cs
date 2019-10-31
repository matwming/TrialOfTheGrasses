using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SumOfEvenNumbersAfterQueriesUnitTest
    {
        public SumOfEvenNumbersAfterQueries SumOfEvenNumbersAfterQueries { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SumOfEvenNumbersAfterQueries = new SumOfEvenNumbersAfterQueries();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var A = new int[] { 1, 2, 3, 4 };
            var queries = new int[4][];
            queries[0] = new int[] { 1, 0 };
            queries[1] = new int[] { -3, 1 };
            queries[2] = new int[] { -4, 0 };
            queries[3] = new int[] { 2, 3 };
            var expected = new int[] { 8, 6, 2, 4 };
            var actual = SumOfEvenNumbersAfterQueries.SumEvenAfterQueries(A, queries);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            var A = new int[] { 1, 2, 3, 4 };
            var queries = new int[4][];
            queries[0] = new int[] { 1, 0 };
            queries[1] = new int[] { -3, 1 };
            queries[2] = new int[] { -4, 0 };
            queries[3] = new int[] { 2, 3 };
            var expected = new int[] { 8, 6, 2, 4 };
            var actual = SumOfEvenNumbersAfterQueries.SumEvenAfterQueriesOptimal(A, queries);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }
    }
}
