using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DistantBarcodesUnitTest
    {
        public DistantBarcodes DistantBarcodes { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DistantBarcodes = new DistantBarcodes();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 1, 1 };
            var expected = new int[] { 1, 2, 1 };
            var actual = DistantBarcodes.RearrangeBarcodes(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 4,3,8,4,4,4,8,3,3,3 };
            var actual = DistantBarcodes.RearrangeBarcodes(input);
            for (int i = 1; i < actual.Length; i++)
            {
                Assert.IsTrue(actual[i - 1] != actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 1,1,1,1,2,2,3,3 };
            var actual = DistantBarcodes.RearrangeBarcodes(input);
            for (int i = 1; i < actual.Length; i++)
            {
                Assert.IsTrue(actual[i - 1] != actual[i]);
            }
        }

    }
}
