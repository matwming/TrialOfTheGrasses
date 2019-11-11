using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DuplicateZerosUnitTest
    {
        public DuplicateZeros DuplicateZeros { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DuplicateZeros = new DuplicateZeros();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            var expected = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 };
            DuplicateZeros.DuplicateZerosSln(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 0, 0, 0 };
            var expected = new int[] { 0, 0, 0 };
            DuplicateZeros.DuplicateZerosSln(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}
