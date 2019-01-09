using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SetMismatchUnitTest
    {
        public SetMismatch setMismatch { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            setMismatch = new SetMismatch();
        }

        [TestMethod, Timeout(20_000)]
        public void SetMismatchTestMethod1()
        {
            var input = new int[] { 1, 2, 2, 4 };
            var expected = new int[] { 2, 3 };
            var actual = setMismatch.FindErrorNums(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void SetMismatchTestMethod2()
        {
            var input = new int[] { 2, 2 };
            var expected = new int[] { 2, 1 };
            var actual = setMismatch.FindErrorNums(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void SetMismatchTestMethod3()
        {
            var input = new int[] { 3, 2, 2 };
            var expected = new int[] { 2, 1 };
            var actual = setMismatch.FindErrorNums(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void SetMismatchTestMethod4()
        {
            var input = new int[] { 2, 3, 2 };
            var expected = new int[] { 2, 1 };
            var actual = setMismatch.FindErrorNums(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
