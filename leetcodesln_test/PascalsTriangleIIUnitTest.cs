using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PascalsTriangleIIUnitTest
    {
        public PascalsTriangleII PascalsTriangleII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PascalsTriangleII = new PascalsTriangleII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 3;
            var expected = new int[] { 1, 3, 3, 1 };
            var actual = PascalsTriangleII.GetRow(input);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        /// <summary>
        ///  This test case will exceed time limit if using non-dp recursion
        /// </summary>
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = 30;
            var expected = new int[] { 1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225, 119759850, 145422675, 155117520, 145422675, 119759850, 86493225, 54627300, 30045015, 14307150, 5852925, 2035800, 593775, 142506, 27405, 4060, 435, 30, 1 };
            var actual = PascalsTriangleII.GetRow(input);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
