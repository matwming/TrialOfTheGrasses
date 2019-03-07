using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PascalsTriangleUnitTest
    {
        public PascalsTriangle PascalsTriangle { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PascalsTriangle = new PascalsTriangle();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var numRows = 5;
            var expected = new int[5][];
            expected[0] = new int[] { 1 };
            expected[1] = new int[] { 1, 1 };
            expected[2] = new int[] { 1, 2, 1 };
            expected[3] = new int[] { 1, 3, 3, 1 };
            expected[4] = new int[] { 1, 4, 6, 4 };
            var actual = PascalsTriangle.Generate(numRows);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < actual[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }

        }
    }
}
