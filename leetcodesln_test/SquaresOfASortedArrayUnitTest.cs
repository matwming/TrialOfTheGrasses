using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SquaresOfASortedArrayUnitTest
    {
        public SquaresOfASortedArray SquaresOfASortedArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SquaresOfASortedArray = new SquaresOfASortedArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { -4, -1, 0, 3, 10 };
            var expected = new int[] { 0, 1, 9, 16, 100 };
            var actual = SquaresOfASortedArray.SortedSquares(input);

            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { -7, -3, 2, 3, 11 };
            var expected = new int[] { 4, 9, 9, 49, 121 };
            var actual = SquaresOfASortedArray.SortedSquares(input);

            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
