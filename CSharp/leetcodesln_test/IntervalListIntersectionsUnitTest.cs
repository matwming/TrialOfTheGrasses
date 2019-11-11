using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class IntervalListIntersectionsUnitTest
    {
        public IntervalListIntersections IntervalListIntersections { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            IntervalListIntersections = new IntervalListIntersections();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = new int[][]
            {
                new int[]{ 0,2},
                new int[]{ 5,10},
                new int[]{ 13,23},
                new int[]{ 24,25}
            };
            var B = new int[][]
            {
                new int[]{ 1,5},
                new int[]{ 8,12},
                new int[]{ 15,24},
                new int[]{ 25,26}
            };
            var expected = new int[][]
            {
                new int[]{ 1,2},
                new int[]{ 5,5},
                new int[]{ 8,10},
                new int[]{ 15,23},
                new int[]{ 24,24},
                new int[]{ 25,25}
            };
            var actual = IntervalListIntersections.IntervalIntersection(A, B);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i][0], actual[i][0]);
                Assert.AreEqual(expected[i][1], actual[i][1]);
            }
        }

    }
}
