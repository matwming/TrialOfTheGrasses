using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ProductOfArrayExceptSelfUnitTest
    {
        public ProductOfArrayExceptSelf ProductOfArrayExceptSelf { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ProductOfArrayExceptSelf = new ProductOfArrayExceptSelf();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new[] { 1, 2, 3, 4 };
            var expected = new[] { 24, 12, 8, 6 };
            var actual = ProductOfArrayExceptSelf.ProductExceptSelf(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new[] { 1, 2, 3, 4 };
            var expected = new[] { 24, 12, 8, 6 };
            var actual = ProductOfArrayExceptSelf.ProductExceptSelfOptimal(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
