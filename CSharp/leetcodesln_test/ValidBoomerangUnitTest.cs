using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidBoomerangUnitTest
    {
        public ValidBoomerang ValidBoomerang { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ValidBoomerang = new ValidBoomerang();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 1, 1 };
            input[1] = new int[] { 2, 2 };
            input[2] = new int[] { 3, 3 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsFalse(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 1, 1 };
            input[1] = new int[] { 2, 3 };
            input[2] = new int[] { 3, 2 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsTrue(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 0 };
            input[1] = new int[] { 0, 2 };
            input[2] = new int[] { 2, 1 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsTrue(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 0 };
            input[1] = new int[] { 1, 0 };
            input[2] = new int[] { 2, 2 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsTrue(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 0 };
            input[1] = new int[] { 2, 0 };
            input[2] = new int[] { 0, 2 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsTrue(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 1 };
            input[1] = new int[] { 1, 0 };
            input[2] = new int[] { 0, 1 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsFalse(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod7()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 1 };
            input[1] = new int[] { 1, 1 };
            input[2] = new int[] { 2, 1 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsFalse(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod8()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 0 };
            input[1] = new int[] { 2, 1 };
            input[2] = new int[] { 2, 1 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsFalse(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod9()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 0 };
            input[1] = new int[] { 2, 0 };
            input[2] = new int[] { 0, 2 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsTrue(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod10()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 2 };
            input[1] = new int[] { 0, 2 };
            input[2] = new int[] { 2, 0 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsFalse(expected);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod11()
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 0, 1 };
            input[1] = new int[] { 0, 2 };
            input[2] = new int[] { 1, 2 };
            var expected = ValidBoomerang.IsBoomerang(input);
            Assert.IsTrue(expected);
        }
    }
}
