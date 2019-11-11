using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class TransposeMatrixUnitTest
    {
        public TransposeMatrix TransposeMatrix { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            TransposeMatrix = new TransposeMatrix();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[3][];
            input[0] = new int[] { 1, 2, 3 };
            input[1] = new int[] { 4, 5, 6 };
            input[2] = new int[] { 7, 8, 9 };
            var expected = new int[3][];
            expected[0] = new int[] { 1, 4, 7 };
            expected[1] = new int[] { 2, 5, 8 };
            expected[2] = new int[] { 3, 6, 9 };
            var actual = TransposeMatrix.Transpose(input);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[2][];
            input[0] = new int[] { 1, 2, 3 };
            input[1] = new int[] { 4, 5, 6 };
            var expected = new int[3][];
            expected[0] = new int[] { 1, 4 };
            expected[1] = new int[] { 2, 5 };
            expected[2] = new int[] { 3, 6 };
            var actual = TransposeMatrix.Transpose(input);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}
