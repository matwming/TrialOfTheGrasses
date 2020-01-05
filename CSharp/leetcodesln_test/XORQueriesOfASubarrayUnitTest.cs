using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class XORQueriesOfASubarrayUnitTest
    {
        public XORQueriesOfASubarray XORQueriesOfASubarray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            XORQueriesOfASubarray = new XORQueriesOfASubarray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var arr = new[] { 1, 3, 4, 8 };
            var queries = new int[4][];
            queries[0] = new[] { 0, 1 };
            queries[1] = new[] { 1, 2 };
            queries[2] = new[] { 0, 3 };
            queries[3] = new[] { 3, 3 };
            var expected = new[] { 2, 7, 14, 8 };
            var actual = XORQueriesOfASubarray.XorQueries(arr, queries);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
