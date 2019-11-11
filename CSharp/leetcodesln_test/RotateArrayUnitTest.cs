using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RotateArrayUnitTest
    {
        public RotateArray RotateArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RotateArray = new RotateArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var k = 3;
            var expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };
            RotateArray.Rotate(input, k);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { -1 };
            var k = 2;
            var expected = new int[] { -1 };
            RotateArray.Rotate(input, k);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}
